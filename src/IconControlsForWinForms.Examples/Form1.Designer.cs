namespace IconControlsForWinForms.Examples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            icon1 = new Icon();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.IconColor = Color.Teal;
            button1.IconName = "door-open";
            button1.IconType = Entities.IconType.Solid;
            button1.IconWidth = 25;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(146, 373);
            button1.Name = "button1";
            button1.Size = new Size(175, 45);
            button1.TabIndex = 4;
            button1.Text = "    Iniciar Sesion";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.IconColor = Color.Black;
            label3.IconName = "user";
            label3.IconType = Entities.IconType.Solid;
            label3.IconWidth = 20;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(80, 264);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 5;
            label3.Text = "          Usuario";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.IconColor = Color.Black;
            label1.IconName = "lock";
            label1.IconType = Entities.IconType.Solid;
            label1.IconWidth = 20;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(80, 308);
            label1.Name = "label1";
            label1.Size = new Size(115, 27);
            label1.TabIndex = 6;
            label1.Text = "          Contraseña";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // icon1
            // 
            icon1.BackgroundImage = (Image)resources.GetObject("icon1.BackgroundImage");
            icon1.BackgroundImageLayout = ImageLayout.Stretch;
            icon1.IconColor = Color.Teal;
            icon1.IconName = "user-alt";
            icon1.IconType = Entities.IconType.Duotone;
            icon1.Location = new Point(146, 52);
            icon1.Name = "icon1";
            icon1.Size = new Size(165, 161);
            icon1.TabIndex = 7;
            icon1.Text = "icon1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 464);
            Controls.Add(icon1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label1;
        private Icon icon1;
    }
}