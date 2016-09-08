namespace GMSvc
{
    partial class MainService
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLogger = new System.Diagnostics.EventLog();
            this.processController = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger)).BeginInit();
            // 
            // eventLogger
            // 
            this.eventLogger.Log = "Application";
            this.eventLogger.Source = "GMSvc";
            // 
            // processController
            // 
            this.processController.StartInfo.Domain = "";
            this.processController.StartInfo.LoadUserProfile = false;
            this.processController.StartInfo.Password = null;
            this.processController.StartInfo.StandardErrorEncoding = null;
            this.processController.StartInfo.StandardOutputEncoding = null;
            this.processController.StartInfo.UserName = "";
            // 
            // MainService
            // 
            this.CanShutdown = true;
            this.ServiceName = "GMSvc";
            ((System.ComponentModel.ISupportInitialize)(this.eventLogger)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLogger;
        private System.Diagnostics.Process processController;
    }
}
