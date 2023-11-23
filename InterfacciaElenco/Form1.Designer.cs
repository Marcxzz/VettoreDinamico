namespace InterfacciaElenco
{
    partial class Form1
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
            buttonAdd = new Button();
            textBox1 = new TextBox();
            buttonGetItemAt = new Button();
            labelItemAt = new Label();
            buttonRemoveAt = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(46, 74);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(109, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add new item";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonGetItemAt
            // 
            buttonGetItemAt.Location = new Point(46, 103);
            buttonGetItemAt.Name = "buttonGetItemAt";
            buttonGetItemAt.Size = new Size(109, 23);
            buttonGetItemAt.TabIndex = 2;
            buttonGetItemAt.Text = "Get item at";
            buttonGetItemAt.UseVisualStyleBackColor = true;
            buttonGetItemAt.Click += buttonGetItemAt_Click;
            // 
            // labelItemAt
            // 
            labelItemAt.AutoSize = true;
            labelItemAt.Location = new Point(187, 48);
            labelItemAt.Name = "labelItemAt";
            labelItemAt.Size = new Size(38, 15);
            labelItemAt.TabIndex = 3;
            labelItemAt.Text = "label1";
            // 
            // buttonRemoveAt
            // 
            buttonRemoveAt.Location = new Point(46, 161);
            buttonRemoveAt.Name = "buttonRemoveAt";
            buttonRemoveAt.Size = new Size(109, 23);
            buttonRemoveAt.TabIndex = 4;
            buttonRemoveAt.Text = "Remove at";
            buttonRemoveAt.UseVisualStyleBackColor = true;
            buttonRemoveAt.Click += buttonRemoveAt_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(46, 132);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(109, 23);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove item";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonRemoveAt);
            Controls.Add(labelItemAt);
            Controls.Add(buttonGetItemAt);
            Controls.Add(textBox1);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBox1;
        private Button buttonGetItemAt;
        private Label labelItemAt;
        private Button buttonRemoveAt;
        private Button buttonRemove;
    }
}
