using System.ComponentModel;

namespace LR5;

partial class GameForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label10 = new System.Windows.Forms.Label();
        this.labelName = new System.Windows.Forms.Label();
        this.labelWeight = new System.Windows.Forms.Label();
        this.labelWallet = new System.Windows.Forms.Label();
        this.labelHealth = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.groupBoxButton = new System.Windows.Forms.GroupBox();
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.groupBoxVillagerActivities = new System.Windows.Forms.GroupBox();
        this.label6 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.groupBoxEnemyActivity = new System.Windows.Forms.GroupBox();
        this.buttonCreeperPunch = new System.Windows.Forms.Button();
        this.buttonNext = new System.Windows.Forms.Button();
        this.buttonReturn = new System.Windows.Forms.Button();
        this.textBoxEvent = new System.Windows.Forms.TextBox();
        this.buttonTravel = new System.Windows.Forms.Button();
        this.groupBoxDoctorActivity = new System.Windows.Forms.GroupBox();
        this.button2 = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        this.groupBoxButton.SuspendLayout();
        this.groupBoxVillagerActivities.SuspendLayout();
        this.groupBoxEnemyActivity.SuspendLayout();
        this.groupBoxDoctorActivity.SuspendLayout();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(6, 169);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBox1.Size = new System.Drawing.Size(196, 145);
        this.textBox1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 23);
        this.label1.TabIndex = 2;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.label10);
        this.groupBox1.Controls.Add(this.labelName);
        this.groupBox1.Controls.Add(this.textBox1);
        this.groupBox1.Controls.Add(this.labelWeight);
        this.groupBox1.Controls.Add(this.labelWallet);
        this.groupBox1.Controls.Add(this.labelHealth);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(208, 320);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Персонаж";
        // 
        // label10
        // 
        this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label10.Location = new System.Drawing.Point(6, 149);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(119, 17);
        this.label10.TabIndex = 8;
        this.label10.Text = "Инвентарь:";
        // 
        // labelName
        // 
        this.labelName.Location = new System.Drawing.Point(58, 32);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(147, 23);
        this.labelName.TabIndex = 7;
        this.labelName.Text = "label9";
        // 
        // labelWeight
        // 
        this.labelWeight.Location = new System.Drawing.Point(131, 113);
        this.labelWeight.Name = "labelWeight";
        this.labelWeight.Size = new System.Drawing.Size(74, 23);
        this.labelWeight.TabIndex = 6;
        this.labelWeight.Text = "label8";
        // 
        // labelWallet
        // 
        this.labelWallet.Location = new System.Drawing.Point(131, 90);
        this.labelWallet.Name = "labelWallet";
        this.labelWallet.Size = new System.Drawing.Size(74, 23);
        this.labelWallet.TabIndex = 5;
        this.labelWallet.Text = "label7";
        // 
        // labelHealth
        // 
        this.labelHealth.Location = new System.Drawing.Point(131, 67);
        this.labelHealth.Name = "labelHealth";
        this.labelHealth.Size = new System.Drawing.Size(74, 23);
        this.labelHealth.TabIndex = 4;
        this.labelHealth.Text = "label6";
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label5.Location = new System.Drawing.Point(6, 90);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(119, 23);
        this.label5.TabIndex = 3;
        this.label5.Text = "Кошелек:";
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label4.Location = new System.Drawing.Point(6, 67);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(119, 23);
        this.label4.TabIndex = 2;
        this.label4.Text = "Здоровье:";
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label3.Location = new System.Drawing.Point(6, 113);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(119, 23);
        this.label3.TabIndex = 1;
        this.label3.Text = "Поднимаемый вес:";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label2.Location = new System.Drawing.Point(6, 32);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(69, 23);
        this.label2.TabIndex = 0;
        this.label2.Text = "Имя:";
        // 
        // groupBoxButton
        // 
        this.groupBoxButton.Controls.Add(this.progressBar1);
        this.groupBoxButton.Controls.Add(this.groupBoxVillagerActivities);
        this.groupBoxButton.Controls.Add(this.groupBoxEnemyActivity);
        this.groupBoxButton.Controls.Add(this.buttonNext);
        this.groupBoxButton.Controls.Add(this.buttonReturn);
        this.groupBoxButton.Controls.Add(this.textBoxEvent);
        this.groupBoxButton.Controls.Add(this.buttonTravel);
        this.groupBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.groupBoxButton.Location = new System.Drawing.Point(226, 12);
        this.groupBoxButton.Name = "groupBoxButton";
        this.groupBoxButton.Size = new System.Drawing.Size(208, 320);
        this.groupBoxButton.TabIndex = 4;
        this.groupBoxButton.TabStop = false;
        this.groupBoxButton.Text = "Путешествие";
        // 
        // progressBar1
        // 
        this.progressBar1.Location = new System.Drawing.Point(6, 275);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(196, 23);
        this.progressBar1.TabIndex = 5;
        this.progressBar1.Visible = false;
        this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
        // 
        // groupBoxVillagerActivities
        // 
        this.groupBoxVillagerActivities.Controls.Add(this.label6);
        this.groupBoxVillagerActivities.Controls.Add(this.button1);
        this.groupBoxVillagerActivities.Location = new System.Drawing.Point(0, 119);
        this.groupBoxVillagerActivities.Name = "groupBoxVillagerActivities";
        this.groupBoxVillagerActivities.Size = new System.Drawing.Size(208, 137);
        this.groupBoxVillagerActivities.TabIndex = 1;
        this.groupBoxVillagerActivities.TabStop = false;
        this.groupBoxVillagerActivities.Text = "Торговец";
        this.groupBoxVillagerActivities.Visible = false;
        // 
        // label6
        // 
        this.label6.Location = new System.Drawing.Point(26, 32);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(146, 23);
        this.label6.TabIndex = 1;
        this.label6.Text = "Аптечка - 200 золотых";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(58, 70);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Купить";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click_1);
        // 
        // groupBoxEnemyActivity
        // 
        this.groupBoxEnemyActivity.Controls.Add(this.buttonCreeperPunch);
        this.groupBoxEnemyActivity.Location = new System.Drawing.Point(6, 119);
        this.groupBoxEnemyActivity.Name = "groupBoxEnemyActivity";
        this.groupBoxEnemyActivity.Size = new System.Drawing.Size(196, 137);
        this.groupBoxEnemyActivity.TabIndex = 4;
        this.groupBoxEnemyActivity.TabStop = false;
        this.groupBoxEnemyActivity.Text = "Крипер";
        this.groupBoxEnemyActivity.Visible = false;
        // 
        // buttonCreeperPunch
        // 
        this.buttonCreeperPunch.Location = new System.Drawing.Point(58, 59);
        this.buttonCreeperPunch.Name = "buttonCreeperPunch";
        this.buttonCreeperPunch.Size = new System.Drawing.Size(75, 23);
        this.buttonCreeperPunch.TabIndex = 0;
        this.buttonCreeperPunch.Text = "Ударить";
        this.buttonCreeperPunch.UseVisualStyleBackColor = true;
        this.buttonCreeperPunch.Click += new System.EventHandler(this.buttonCreeperPunch_Click);
        // 
        // buttonNext
        // 
        this.buttonNext.Location = new System.Drawing.Point(6, 262);
        this.buttonNext.Name = "buttonNext";
        this.buttonNext.Size = new System.Drawing.Size(196, 23);
        this.buttonNext.TabIndex = 3;
        this.buttonNext.Text = "Продолжить идти";
        this.buttonNext.UseVisualStyleBackColor = true;
        this.buttonNext.Visible = false;
        this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
        // 
        // buttonReturn
        // 
        this.buttonReturn.Location = new System.Drawing.Point(6, 291);
        this.buttonReturn.Name = "buttonReturn";
        this.buttonReturn.Size = new System.Drawing.Size(196, 23);
        this.buttonReturn.TabIndex = 2;
        this.buttonReturn.Text = "button1";
        this.buttonReturn.UseVisualStyleBackColor = true;
        this.buttonReturn.Visible = false;
        this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
        // 
        // textBoxEvent
        // 
        this.textBoxEvent.Location = new System.Drawing.Point(6, 19);
        this.textBoxEvent.Multiline = true;
        this.textBoxEvent.Name = "textBoxEvent";
        this.textBoxEvent.ReadOnly = true;
        this.textBoxEvent.Size = new System.Drawing.Size(196, 94);
        this.textBoxEvent.TabIndex = 1;
        this.textBoxEvent.Visible = false;
        // 
        // buttonTravel
        // 
        this.buttonTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.buttonTravel.Location = new System.Drawing.Point(64, 149);
        this.buttonTravel.Name = "buttonTravel";
        this.buttonTravel.Size = new System.Drawing.Size(75, 23);
        this.buttonTravel.TabIndex = 0;
        this.buttonTravel.Text = "Вперед!";
        this.buttonTravel.UseVisualStyleBackColor = true;
        this.buttonTravel.Click += new System.EventHandler(this.button1_Click);
        // 
        // groupBoxDoctorActivity
        // 
        this.groupBoxDoctorActivity.Controls.Add(this.button2);
        this.groupBoxDoctorActivity.Location = new System.Drawing.Point(223, 131);
        this.groupBoxDoctorActivity.Name = "groupBoxDoctorActivity";
        this.groupBoxDoctorActivity.Size = new System.Drawing.Size(202, 137);
        this.groupBoxDoctorActivity.TabIndex = 2;
        this.groupBoxDoctorActivity.TabStop = false;
        this.groupBoxDoctorActivity.Text = "Доктор";
        this.groupBoxDoctorActivity.Visible = false;
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(62, 58);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(75, 23);
        this.button2.TabIndex = 0;
        this.button2.Text = "Лечить";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // GameForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(445, 342);
        this.Controls.Add(this.groupBoxDoctorActivity);
        this.Controls.Add(this.groupBoxButton);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Name = "GameForm";
        this.Text = "GameForm";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBoxButton.ResumeLayout(false);
        this.groupBoxButton.PerformLayout();
        this.groupBoxVillagerActivities.ResumeLayout(false);
        this.groupBoxEnemyActivity.ResumeLayout(false);
        this.groupBoxDoctorActivity.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBoxDoctorActivity;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.GroupBox groupBoxVillagerActivities;

    private System.Windows.Forms.ProgressBar progressBar1;

    private System.Windows.Forms.Button buttonCreeperPunch;

    private System.Windows.Forms.GroupBox groupBoxEnemyActivity;

    private System.Windows.Forms.Button buttonNext;

    private System.Windows.Forms.Button buttonReturn;

    private System.Windows.Forms.TextBox textBoxEvent;

    private System.Windows.Forms.Button buttonTravel;

    private System.Windows.Forms.GroupBox groupBoxButton;

    private System.Windows.Forms.Label labelWeight;

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label labelWallet;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label labelHealth;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    #endregion
}