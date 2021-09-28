
namespace Lab10_Robot
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
            this.labelPos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelArrow = new System.Windows.Forms.Label();
            this.buttonGo1 = new System.Windows.Forms.Button();
            this.buttonGo10 = new System.Windows.Forms.Button();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(19, 9);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(72, 17);
            this.labelPos.TabIndex = 0;
            this.labelPos.Text = "{X=0,Y=0}";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelArrow);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 1;
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelArrow.Location = new System.Drawing.Point(140, 140);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(19, 15);
            this.labelArrow.TabIndex = 9;
            this.labelArrow.Text = "T";
            // 
            // buttonGo1
            // 
            this.buttonGo1.Location = new System.Drawing.Point(48, 378);
            this.buttonGo1.Name = "buttonGo1";
            this.buttonGo1.Size = new System.Drawing.Size(57, 30);
            this.buttonGo1.TabIndex = 2;
            this.buttonGo1.Text = "Go 1";
            this.buttonGo1.UseVisualStyleBackColor = true;
            this.buttonGo1.Click += new System.EventHandler(this.buttonGo1_Click);
            // 
            // buttonGo10
            // 
            this.buttonGo10.Location = new System.Drawing.Point(205, 378);
            this.buttonGo10.Name = "buttonGo10";
            this.buttonGo10.Size = new System.Drawing.Size(63, 30);
            this.buttonGo10.TabIndex = 3;
            this.buttonGo10.Text = "Go 10";
            this.buttonGo10.UseVisualStyleBackColor = true;
            this.buttonGo10.Click += new System.EventHandler(this.buttonGo10_Click);
            // 
            // buttonNorth
            // 
            this.buttonNorth.Location = new System.Drawing.Point(139, 350);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(30, 30);
            this.buttonNorth.TabIndex = 4;
            this.buttonNorth.Text = "N";
            this.buttonNorth.UseVisualStyleBackColor = true;
            this.buttonNorth.Click += new System.EventHandler(this.buttonNorth_Click);
            // 
            // buttonEast
            // 
            this.buttonEast.Location = new System.Drawing.Point(167, 378);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(30, 30);
            this.buttonEast.TabIndex = 5;
            this.buttonEast.Text = "E";
            this.buttonEast.UseVisualStyleBackColor = true;
            this.buttonEast.Click += new System.EventHandler(this.buttonEast_Click);
            // 
            // buttonWest
            // 
            this.buttonWest.Location = new System.Drawing.Point(111, 378);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(30, 30);
            this.buttonWest.TabIndex = 6;
            this.buttonWest.Text = "W";
            this.buttonWest.UseVisualStyleBackColor = true;
            this.buttonWest.Click += new System.EventHandler(this.buttonWest_Click);
            // 
            // buttonSouth
            // 
            this.buttonSouth.Location = new System.Drawing.Point(139, 407);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(30, 30);
            this.buttonSouth.TabIndex = 7;
            this.buttonSouth.Text = "S";
            this.buttonSouth.UseVisualStyleBackColor = true;
            this.buttonSouth.Click += new System.EventHandler(this.buttonSouth_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(156, 460);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 29);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGo10;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(347, 513);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSouth);
            this.Controls.Add(this.buttonWest);
            this.Controls.Add(this.buttonEast);
            this.Controls.Add(this.buttonNorth);
            this.Controls.Add(this.buttonGo10);
            this.Controls.Add(this.buttonGo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPos);
            this.Name = "Form1";
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Button buttonGo1;
        private System.Windows.Forms.Button buttonGo10;
        private System.Windows.Forms.Button buttonNorth;
        private System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.Button buttonSouth;
        private System.Windows.Forms.Button buttonExit;
    }
}

