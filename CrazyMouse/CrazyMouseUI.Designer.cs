namespace CrazyMouse
{
    partial class CrazyMouseUI
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
            this.BtnClickerStart = new System.Windows.Forms.Button();
            this.TbxClickerKey = new System.Windows.Forms.TextBox();
            this.TbcCrazyMouse = new System.Windows.Forms.TabControl();
            this.TabJiggler = new System.Windows.Forms.TabPage();
            this.TbxJigglerFrequency = new System.Windows.Forms.TextBox();
            this.BtnJigglerStart = new System.Windows.Forms.Button();
            this.LblJigglerFrequency = new System.Windows.Forms.Label();
            this.TabClicker = new System.Windows.Forms.TabPage();
            this.LblClickerKey = new System.Windows.Forms.Label();
            this.LblFooter = new System.Windows.Forms.Label();
            this.TbcCrazyMouse.SuspendLayout();
            this.TabJiggler.SuspendLayout();
            this.TabClicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClickerStart
            // 
            this.BtnClickerStart.Enabled = false;
            this.BtnClickerStart.Location = new System.Drawing.Point(184, 77);
            this.BtnClickerStart.Name = "BtnClickerStart";
            this.BtnClickerStart.Size = new System.Drawing.Size(94, 29);
            this.BtnClickerStart.TabIndex = 1;
            this.BtnClickerStart.Text = "Start";
            this.BtnClickerStart.UseVisualStyleBackColor = true;
            this.BtnClickerStart.Click += new System.EventHandler(this.BtnClickerStart_Click);
            // 
            // TbxClickerKey
            // 
            this.TbxClickerKey.Location = new System.Drawing.Point(198, 36);
            this.TbxClickerKey.MaxLength = 1;
            this.TbxClickerKey.Name = "TbxClickerKey";
            this.TbxClickerKey.Size = new System.Drawing.Size(80, 27);
            this.TbxClickerKey.TabIndex = 2;
            this.TbxClickerKey.TextChanged += new System.EventHandler(this.TbxClickerKey_TextChanged);
            // 
            // TbcCrazyMouse
            // 
            this.TbcCrazyMouse.Controls.Add(this.TabJiggler);
            this.TbcCrazyMouse.Controls.Add(this.TabClicker);
            this.TbcCrazyMouse.Location = new System.Drawing.Point(1, 0);
            this.TbcCrazyMouse.Name = "TbcCrazyMouse";
            this.TbcCrazyMouse.SelectedIndex = 0;
            this.TbcCrazyMouse.Size = new System.Drawing.Size(334, 159);
            this.TbcCrazyMouse.TabIndex = 0;
            // 
            // TabJiggler
            // 
            this.TabJiggler.Controls.Add(this.TbxJigglerFrequency);
            this.TabJiggler.Controls.Add(this.BtnJigglerStart);
            this.TabJiggler.Controls.Add(this.LblJigglerFrequency);
            this.TabJiggler.Location = new System.Drawing.Point(4, 29);
            this.TabJiggler.Name = "TabJiggler";
            this.TabJiggler.Padding = new System.Windows.Forms.Padding(3);
            this.TabJiggler.Size = new System.Drawing.Size(326, 126);
            this.TabJiggler.TabIndex = 0;
            this.TabJiggler.Text = "Jiggler";
            this.TabJiggler.UseVisualStyleBackColor = true;
            // 
            // TbxJigglerFrequency
            // 
            this.TbxJigglerFrequency.Location = new System.Drawing.Point(130, 20);
            this.TbxJigglerFrequency.MaxLength = 4;
            this.TbxJigglerFrequency.Name = "TbxJigglerFrequency";
            this.TbxJigglerFrequency.Size = new System.Drawing.Size(125, 27);
            this.TbxJigglerFrequency.TabIndex = 2;
            this.TbxJigglerFrequency.TextChanged += new System.EventHandler(this.TbxJigglerFrequency_TextChanged);
            this.TbxJigglerFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxJigglerFrequency_KeyPress);
            // 
            // BtnJigglerStart
            // 
            this.BtnJigglerStart.Enabled = false;
            this.BtnJigglerStart.Location = new System.Drawing.Point(26, 76);
            this.BtnJigglerStart.Name = "BtnJigglerStart";
            this.BtnJigglerStart.Size = new System.Drawing.Size(94, 29);
            this.BtnJigglerStart.TabIndex = 1;
            this.BtnJigglerStart.Text = "Start";
            this.BtnJigglerStart.UseVisualStyleBackColor = true;
            this.BtnJigglerStart.Click += new System.EventHandler(this.BtnJigglerStart_Click);
            // 
            // LblJigglerFrequency
            // 
            this.LblJigglerFrequency.AutoSize = true;
            this.LblJigglerFrequency.Location = new System.Drawing.Point(26, 20);
            this.LblJigglerFrequency.Name = "LblJigglerFrequency";
            this.LblJigglerFrequency.Size = new System.Drawing.Size(76, 20);
            this.LblJigglerFrequency.TabIndex = 0;
            this.LblJigglerFrequency.Text = "Frequency";
            // 
            // TabClicker
            // 
            this.TabClicker.Controls.Add(this.LblClickerKey);
            this.TabClicker.Controls.Add(this.TbxClickerKey);
            this.TabClicker.Controls.Add(this.BtnClickerStart);
            this.TabClicker.Location = new System.Drawing.Point(4, 29);
            this.TabClicker.Name = "TabClicker";
            this.TabClicker.Padding = new System.Windows.Forms.Padding(3);
            this.TabClicker.Size = new System.Drawing.Size(326, 126);
            this.TabClicker.TabIndex = 1;
            this.TabClicker.Text = "Clicker";
            this.TabClicker.UseVisualStyleBackColor = true;
            // 
            // LblClickerKey
            // 
            this.LblClickerKey.AutoSize = true;
            this.LblClickerKey.Location = new System.Drawing.Point(27, 39);
            this.LblClickerKey.Name = "LblClickerKey";
            this.LblClickerKey.Size = new System.Drawing.Size(108, 20);
            this.LblClickerKey.TabIndex = 3;
            this.LblClickerKey.Text = "Set Toggle Key";
            // 
            // LblFooter
            // 
            this.LblFooter.AutoSize = true;
            this.LblFooter.Location = new System.Drawing.Point(12, 462);
            this.LblFooter.Name = "LblFooter";
            this.LblFooter.Size = new System.Drawing.Size(50, 20);
            this.LblFooter.TabIndex = 4;
            this.LblFooter.Text = "label2";
            // 
            // CrazyMouseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 491);
            this.Controls.Add(this.LblFooter);
            this.Controls.Add(this.TbcCrazyMouse);
            this.Name = "CrazyMouseUI";
            this.Text = "CrazyMouseUI";
            this.TbcCrazyMouse.ResumeLayout(false);
            this.TabJiggler.ResumeLayout(false);
            this.TabJiggler.PerformLayout();
            this.TabClicker.ResumeLayout(false);
            this.TabClicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnClickerStart;
        private TextBox TbxClickerKey;
        private TabControl TbcCrazyMouse;
        private TabPage TabJiggler;
        private TabPage TabClicker;
        private TextBox TbxJigglerFrequency;
        private Button BtnJigglerStart;
        private Label LblJigglerFrequency;
        private Label LblClickerKey;
        private Label LblFooter;
    }
}