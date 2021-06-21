
namespace ScreenCoordinate
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VerticalValue = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.HorizontalValue = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.VerticalValue);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.HorizontalValue);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "nahian";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerticalValue
            // 
            this.VerticalValue.AutoSize = true;
            this.VerticalValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VerticalValue.Location = new System.Drawing.Point(111, 39);
            this.VerticalValue.Name = "VerticalValue";
            this.VerticalValue.Size = new System.Drawing.Size(35, 16);
            this.VerticalValue.TabIndex = 3;
            this.VerticalValue.Text = "0000";
            this.VerticalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY.Location = new System.Drawing.Point(12, 39);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(80, 16);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Vertical (Y) :";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HorizontalValue
            // 
            this.HorizontalValue.AutoSize = true;
            this.HorizontalValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HorizontalValue.Location = new System.Drawing.Point(111, 17);
            this.HorizontalValue.Name = "HorizontalValue";
            this.HorizontalValue.Size = new System.Drawing.Size(35, 16);
            this.HorizontalValue.TabIndex = 1;
            this.HorizontalValue.Text = "0000";
            this.HorizontalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(12, 17);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(95, 16);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Horizontal (X) :";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 80);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppForm";
            this.Text = "Cursor Location";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppForm_FormClosed);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label VerticalValue;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label HorizontalValue;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label1;
    }
}

