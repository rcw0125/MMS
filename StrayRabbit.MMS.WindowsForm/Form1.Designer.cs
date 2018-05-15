namespace StrayRabbit.MMS.WindowsForm
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavSubItem3 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavSubItem4 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavSubItem5 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.SuspendLayout();
            // 
            // tileNavSubItem3
            // 
            this.tileNavSubItem3.Caption = "tileNavSubItem3";
            this.tileNavSubItem3.Name = "tileNavSubItem3";
            // 
            // 
            // 
            this.tileNavSubItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "tileNavSubItem3";
            this.tileNavSubItem3.Tile.Elements.Add(tileItemElement1);
            this.tileNavSubItem3.Tile.Name = "tileBarItem9";
            // 
            // tileNavSubItem4
            // 
            this.tileNavSubItem4.Caption = "tileNavSubItem4";
            this.tileNavSubItem4.Name = "tileNavSubItem4";
            // 
            // 
            // 
            this.tileNavSubItem4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "tileNavSubItem4";
            this.tileNavSubItem4.Tile.Elements.Add(tileItemElement2);
            this.tileNavSubItem4.Tile.Name = "tileBarItem10";
            // 
            // tileNavSubItem5
            // 
            this.tileNavSubItem5.Caption = "tileNavSubItem5";
            this.tileNavSubItem5.Name = "tileNavSubItem5";
            // 
            // 
            // 
            this.tileNavSubItem5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "tileNavSubItem5";
            this.tileNavSubItem5.Tile.Elements.Add(tileItemElement3);
            this.tileNavSubItem5.Tile.Name = "tileBarItem11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem3;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem4;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem5;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}