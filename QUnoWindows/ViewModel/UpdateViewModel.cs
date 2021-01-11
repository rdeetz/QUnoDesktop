// <copyright file="UpdateViewModel.cs" company="Mooville">
//   Copyright © 2018 Roger Deetz. All rights reserved.
// </copyright>

namespace Mooville.QUno.ViewModel
{
    using System;
    using System.ComponentModel;
    using System.Reflection;
    using Mooville.Common.Updates;
    using Mooville.QUno.Properties;

    public class UpdateViewModel : ViewModelBase, IDisposable
    {
        private string title;
        private string message;
        private bool isWorking;
        private bool hasUpdate;
        private string updateAddress;
        private IUpdateService updateService;
        private BackgroundWorker worker;

        public UpdateViewModel()
            : this(new UpdateService())
        {
        }

        public UpdateViewModel(IUpdateService updateService)
        {
            this.updateService = updateService;
            this.worker = new BackgroundWorker();
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new DoWorkEventHandler(this.Worker_DoWork);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
        }

        public event EventHandler CheckForUpdatesCompleted;

        #region Public Properties

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
                this.OnPropertyChanged("Message");
            }
        }

        public bool IsWorking
        {
            get
            {
                return this.isWorking;
            }

            set
            {
                this.isWorking = value;
                this.OnPropertyChanged("IsWorking");
            }
        }

        public bool HasUpdate
        {
            get
            {
                return this.hasUpdate;
            }

            set
            {
                this.hasUpdate = value;
                this.OnPropertyChanged("HasUpdate");
            }
        }

        public string UpdateAddress
        {
            get
            {
                return this.updateAddress;
            }

            set
            {
                this.updateAddress = value;
                this.OnPropertyChanged("UpdateAddress");
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);

            return;
        }

        #endregion

        public void CheckForUpdates()
        {
            this.IsWorking = true;
            this.Title = Resources.TitleCheckForUpdatesWorking;
            this.Message = String.Empty;
            this.HasUpdate = false;
            this.UpdateAddress = null;

            this.worker.RunWorkerAsync(this.updateService);

            return;
        }

        public void CancelCheckForUpdates()
        {
            if (!this.worker.CancellationPending && this.worker.IsBusy)
            {
                this.worker.CancelAsync();

                this.IsWorking = false;
                this.Title = Resources.TitleCheckForUpdatesCancelled;
                this.Message = String.Empty;
                this.HasUpdate = false;
                this.UpdateAddress = null;
            }

            return;
        }

        protected void OnCheckForUpdatesCompleted()
        {
            EventHandler tmp = this.CheckForUpdatesCompleted;

            if (tmp != null)
            {
                tmp(this, new EventArgs());
            }

            return;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.worker != null)
                {
                    this.worker.Dispose();
                }
            }

            return;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            IUpdateService updateService = e.Argument as IUpdateService;

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            UpdateResult result = updateService.CheckForUpdates(Settings.Default.ProductCode, version);

            e.Result = result;

            return;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateResult result = e.Result as UpdateResult;

            this.IsWorking = false;

            switch (result.ResultType)
            {
                case UpdateResultType.Error:
                    this.Title = Resources.TitleCheckForUpdatesError;
                    this.Message = result.Exception.Message; // I don't like this; exception messages are not user-friendly.
                    this.HasUpdate = false;
                    this.UpdateAddress = null;
                    break;

                case UpdateResultType.NoUpdateAvailable:
                    this.Title = Resources.TitleCheckForUpdatesNoUpdateAvailable;
                    this.Message = String.Empty;
                    this.HasUpdate = false;
                    this.UpdateAddress = null;
                    break;

                case UpdateResultType.UpdateAvailable:
                    this.Title = Resources.TitleCheckForUpdatesUpdateAvailable;
                    this.Message = Resources.MessageCheckForUpdatesUpdateAvailable;
                    this.HasUpdate = true;
                    this.UpdateAddress = result.Address;
                    break;
            }

            // This event is really only useful for unit testing. 
            // Regular user interfaces are expected to bind directly to the public properties.
            this.OnCheckForUpdatesCompleted();

            return;
        }
    }
}
