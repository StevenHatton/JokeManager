
namespace JokeForm
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblPrompt1 = new System.Windows.Forms.Label();
            this.lblPrompt2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(441, 182);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(131, 22);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(217, 182);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(131, 22);
            this.txtInput2.TabIndex = 1;
            // 
            // lblPrompt1
            // 
            this.lblPrompt1.AutoSize = true;
            this.lblPrompt1.Location = new System.Drawing.Point(438, 147);
            this.lblPrompt1.Name = "lblPrompt1";
            this.lblPrompt1.Size = new System.Drawing.Size(156, 17);
            this.lblPrompt1.TabIndex = 2;
            this.lblPrompt1.Text = "Please enter your [6+2]";
            // 
            // lblPrompt2
            // 
            this.lblPrompt2.AutoSize = true;
            this.lblPrompt2.Location = new System.Drawing.Point(214, 147);
            this.lblPrompt2.Name = "lblPrompt2";
            this.lblPrompt2.Size = new System.Drawing.Size(130, 17);
            this.lblPrompt2.TabIndex = 3;
            this.lblPrompt2.Text = "Please enter a joke";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(374, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "___";
            // 
            // cmdCheck
            // 
            this.cmdCheck.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdCheck.Location = new System.Drawing.Point(353, 308);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(66, 27);
            this.cmdCheck.TabIndex = 5;
            this.cmdCheck.Text = "Check";
            this.cmdCheck.UseVisualStyleBackColor = false;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPrompt2);
            this.Controls.Add(this.lblPrompt1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "hattonsn_FinalAssignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label lblPrompt1;
        private System.Windows.Forms.Label lblPrompt2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button cmdCheck;
    }
}

