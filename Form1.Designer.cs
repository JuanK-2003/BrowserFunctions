
namespace BrowserFunctions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(784, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 43);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(865, 19);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 43);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New Tab";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(142, 25);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(636, 22);
            this.textURL.TabIndex = 2;
            this.textURL.TextChanged += new System.EventHandler(this.textURL_TextChanged);
            this.textURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textURL_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(930, 612);
            this.webBrowser.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(3, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 647);
            this.tabControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 708);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TabControl tabControl;
    }
}

