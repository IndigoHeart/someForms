namespace someForms.Views
{
    partial class TrackView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditComposer = new DevExpress.XtraEditors.TextEdit();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComposer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(22, 29);
            this.textEditID.Name = "textEditID";
            this.textEditID.Size = new System.Drawing.Size(231, 20);
            this.textEditID.TabIndex = 0;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(22, 55);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(231, 20);
            this.textEditName.TabIndex = 1;
            // 
            // textEditComposer
            // 
            this.textEditComposer.Location = new System.Drawing.Point(22, 81);
            this.textEditComposer.Name = "textEditComposer";
            this.textEditComposer.Size = new System.Drawing.Size(231, 20);
            this.textEditComposer.TabIndex = 2;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(someForms.ViewModels.TrackViewModel), "TrackId", this.textEditID, "EditValue"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(someForms.ViewModels.TrackViewModel), "Name", this.textEditName, "EditValue"),
            DevExpress.Utils.MVVM.BindingExpression.CreatePropertyBinding(typeof(someForms.ViewModels.TrackViewModel), "Composer", this.textEditComposer, "EditValue")});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(someForms.ViewModels.TrackViewModel);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(260, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // TrackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEditComposer);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.textEditID);
            this.Name = "TrackView";
            this.Size = new System.Drawing.Size(399, 353);
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComposer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.TextEdit textEditComposer;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
