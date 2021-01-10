Imports Mooville.QUno.Model

Public Class MainForm
    Enum LogMode
        Play
        WildPlay
        Draw
    End Enum

    Dim WithEvents CurrentGame As Game
    Dim HumanPlayer As Player
    Dim Log As List(Of String)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToggleGameControlsUI()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'StartNewGame(My.Settings.DefaultHumanPlayerName, My.Settings.DefaultComputerPlayers)
        StartNewGame("Player 1", 3)
        SetNewGameUI()
        ToggleGameControlsUI()
        RefreshGameStatusUI()
    End Sub

    Private Sub PlayerChanged(sender As Object, e As EventArgs) Handles CurrentGame.PlayerChanged
        If Not CurrentGame.IsGameOver Then
            Dim player As Player = CurrentGame.CurrentPlayer
            If Not player.IsHuman Then
                Dim cardToPlay As Card = player.ChooseCardToPlay(CurrentGame)
                If cardToPlay IsNot Nothing Then
                    If cardToPlay.Color = Color.Wild Then
                        Dim wildColor As Color = player.ChooseWildColor()
                        LogTurnUI(player, cardToPlay, wildColor, LogMode.WildPlay)
                        CurrentGame.PlayCard(cardToPlay, wildColor)
                    Else
                        LogTurnUI(player, cardToPlay, Nothing, LogMode.Play)
                        CurrentGame.PlayCard(cardToPlay)
                    End If
                Else
                    LogTurnUI(player, Nothing, Nothing, LogMode.Draw)
                    Dim cardToDraw As Card = CurrentGame.DrawCard()
                    player.Hand.Cards.Add(cardToDraw)
                End If
            End If
            RefreshGameStatusUI()
        Else
            SetGameOverUI()
            ToggleGameControlsUI()
        End If
    End Sub

    Private Sub ListHumanHand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listHumanHand.SelectedIndexChanged
        If Not listHumanHand.Enabled Then
            buttonPlay.Enabled = False
        Else
            Dim selectedCard As Card = listHumanHand.SelectedItem
            buttonPlay.Enabled = CurrentGame.CanPlay(selectedCard)
        End If
    End Sub

    Private Sub ListHumanHand_DoubleClick(sender As Object, e As EventArgs) Handles listHumanHand.DoubleClick
        Dim selectedCard As Card = listHumanHand.SelectedItem
        If CurrentGame.CanPlay(selectedCard) Then
            PlayCardUI(selectedCard)
            RefreshGameStatusUI()
        End If
    End Sub

    Private Sub ListHumanHand_KeyUp(sender As Object, e As KeyEventArgs) Handles listHumanHand.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim selectedCard As Card = listHumanHand.SelectedItem
            If CurrentGame.CanPlay(selectedCard) Then
                PlayCardUI(selectedCard)
                RefreshGameStatusUI()
            End If
        ElseIf e.KeyCode = Keys.Space Then
            LogTurnUI(HumanPlayer, Nothing, Nothing, LogMode.Draw)
            Dim drawnCard = CurrentGame.DrawCard()
            HumanPlayer.Hand.Cards.Add(drawnCard)
            RefreshGameStatusUI()
        End If
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles buttonPlay.Click
        Dim selectedCard As Card = listHumanHand.SelectedItem
        PlayCardUI(selectedCard)
        RefreshGameStatusUI()
    End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles buttonDraw.Click
        LogTurnUI(HumanPlayer, Nothing, Nothing, LogMode.Draw)
        Dim drawnCard = CurrentGame.DrawCard()
        HumanPlayer.Hand.Cards.Add(drawnCard)
        RefreshGameStatusUI()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim result As DialogResult = OptionsForm.ShowDialog(Me)
    End Sub

    Private Sub AboutQUnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog(Me)
    End Sub

    Private Sub StartNewGame(humanPlayerName As String, computerPlayerCount As Integer)
        CurrentGame = New Game
        Log = New List(Of String)

        HumanPlayer = New Player
        With HumanPlayer
            .Name = humanPlayerName
            .IsHuman = True
        End With
        CurrentGame.Players.Add(HumanPlayer)

        For i = 1 To computerPlayerCount
            Dim computerPlayer As New Player
            With computerPlayer
                '.Name = String.Format(My.Resources.PlayerNameTemplate, i + 1) ' Since the human is Player 1.
                .Name = String.Format("Player {0}", i + 1) ' Since the human is Player 1.
                .IsHuman = False
            End With
            CurrentGame.Players.Add(computerPlayer)
        Next

        CurrentGame.Deal()
    End Sub

    Private Function IsGameInProgress() As Boolean
        Dim inProgress As Boolean = False
        If CurrentGame IsNot Nothing Then
            If Not CurrentGame.IsGameOver Then
                inProgress = True
            End If
        End If
        Return inProgress
    End Function

    Private Function FindWinner() As String
        Dim winner As Player = CurrentGame.Players.First(Function(p) p.Hand.Cards.Count = 0)
        Return winner.Name
    End Function

    Private Sub SetNewGameUI()
        listGameLog.Items.Clear()
        labelHumanName.Text = HumanPlayer.Name
    End Sub

    Private Sub ToggleGameControlsUI()
        If IsGameInProgress() Then
            listHumanHand.Enabled = True
            buttonPlay.Enabled = True ' Set it to True, then rely on the selected item in the list to update it.
            buttonDraw.Enabled = True
            labelStatus.Text = "Game in progress" 'My.Resources.StatusGameInProgress
        Else
            listHumanHand.Enabled = False
            buttonPlay.Enabled = False
            buttonDraw.Enabled = False
        End If
    End Sub

    Private Sub RefreshGameStatusUI()
        listHumanHand.Items.Clear()
        For Each card In HumanPlayer.Hand.Cards
            listHumanHand.Items.Add(card)
        Next
        If listHumanHand.Items.Count > 0 Then
            listHumanHand.SelectedIndex = 0
        End If

        textCurrentPlayer.Text = CurrentGame.CurrentPlayer.Name
        textCurrentCard.Text = CurrentGame.Deck.CurrentCard.ToString()
        textCurrentDirection.Text = CurrentGame.CurrentDirection.ToString()
        textCurrentWildColor.Text = CurrentGame.Deck.CurrentWildColor.ToString()

        listComputerPlayers.Items.Clear()
        For Each player In CurrentGame.Players.Where(Function(p) Not p.IsHuman)
            'listComputerPlayers.Items.Add(String.Format(My.Resources.ComputerPlayerNameAndStatus, player.Name, player.Hand.Cards.Count))
            listComputerPlayers.Items.Add(String.Format("{0} has {1} cards left", player.Name, player.Hand.Cards.Count))
        Next

        listHumanHand.Focus()
    End Sub

    Private Sub SetGameOverUI()
        'labelStatus.Text = String.Format(My.Resources.StatusGameOver, FindWinner())
        labelStatus.Text = String.Format("Game over! {0} is the winner.", FindWinner())
    End Sub

    Private Sub PlayCardUI(selectedCard As Card)
        If selectedCard.Color = Color.Wild Then
            Dim result As DialogResult = WildColorForm.ShowDialog(Me)
            If result = DialogResult.OK Then
                Dim wildColor As Color = WildColorForm.WildColor
                LogTurnUI(HumanPlayer, selectedCard, wildColor, LogMode.WildPlay)
                HumanPlayer.Hand.Cards.Remove(selectedCard)
                CurrentGame.PlayCard(selectedCard, wildColor)
            End If
        Else
            LogTurnUI(HumanPlayer, selectedCard, Nothing, LogMode.Play)
            HumanPlayer.Hand.Cards.Remove(selectedCard)
            CurrentGame.PlayCard(selectedCard)
        End If
    End Sub

    Private Sub LogTurnUI(player As Player, card As Card, wildColor As Color?, mode As LogMode)
        Dim message As String = String.Empty
        Select Case mode
            Case LogMode.Play
                'message = String.Format(My.Resources.LogMessagePlay, player.Name, card.ToString())
                message = String.Format("{0} played {1}", player.Name, card.ToString())
            Case LogMode.WildPlay
                'message = String.Format(My.Resources.LogMessageWildPlay, player.Name, card.Value.ToString(), wildColor.ToString())
                message = String.Format("{0} played {1} and chose {2}", player.Name, card.Value.ToString(), wildColor.ToString())
            Case LogMode.Draw
                'message = String.Format(My.Resources.LogMessageDraw, player.Name)
                message = String.Format("{0} drew a card", player.Name)
        End Select
        Log.Add(message)
        listGameLog.Items.Insert(0, message)
    End Sub
End Class
