namespace RungeKutt
{
    partial class RungeKutt_Methods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RungeKutt_Methods));
            this.databaseRungeKutt = new RungeKutt.DatabaseRungeKutt();
            this.rungeKuttDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rungeKuttDatabaseTableAdapter = new RungeKutt.DatabaseRungeKuttTableAdapters.RungeKuttDatabaseTableAdapter();
            this.tableAdapterManager = new RungeKutt.DatabaseRungeKuttTableAdapters.TableAdapterManager();
            this.rungeKuttDatabaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rungeKuttDatabaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rungeKuttDatabaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compute = new System.Windows.Forms.Button();
            this.xOTextBox = new System.Windows.Forms.TextBox();
            this.yOtextBox = new System.Windows.Forms.TextBox();
            this.xOLabel = new System.Windows.Forms.Label();
            this.yOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRungeKutt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseBindingNavigator)).BeginInit();
            this.rungeKuttDatabaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseRungeKutt
            // 
            this.databaseRungeKutt.DataSetName = "DatabaseRungeKutt";
            this.databaseRungeKutt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rungeKuttDatabaseBindingSource
            // 
            this.rungeKuttDatabaseBindingSource.DataMember = "RungeKuttDatabase";
            this.rungeKuttDatabaseBindingSource.DataSource = this.databaseRungeKutt;
            // 
            // rungeKuttDatabaseTableAdapter
            // 
            this.rungeKuttDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RungeKuttDatabaseTableAdapter = this.rungeKuttDatabaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = RungeKutt.DatabaseRungeKuttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rungeKuttDatabaseBindingNavigator
            // 
            this.rungeKuttDatabaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rungeKuttDatabaseBindingNavigator.BindingSource = this.rungeKuttDatabaseBindingSource;
            this.rungeKuttDatabaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rungeKuttDatabaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rungeKuttDatabaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rungeKuttDatabaseBindingNavigatorSaveItem});
            this.rungeKuttDatabaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rungeKuttDatabaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rungeKuttDatabaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rungeKuttDatabaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rungeKuttDatabaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rungeKuttDatabaseBindingNavigator.Name = "rungeKuttDatabaseBindingNavigator";
            this.rungeKuttDatabaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rungeKuttDatabaseBindingNavigator.Size = new System.Drawing.Size(745, 25);
            this.rungeKuttDatabaseBindingNavigator.TabIndex = 0;
            this.rungeKuttDatabaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rungeKuttDatabaseBindingNavigatorSaveItem
            // 
            this.rungeKuttDatabaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rungeKuttDatabaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rungeKuttDatabaseBindingNavigatorSaveItem.Image")));
            this.rungeKuttDatabaseBindingNavigatorSaveItem.Name = "rungeKuttDatabaseBindingNavigatorSaveItem";
            this.rungeKuttDatabaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rungeKuttDatabaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rungeKuttDatabaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.rungeKuttDatabaseBindingNavigatorSaveItem_Click);
            // 
            // rungeKuttDatabaseDataGridView
            // 
            this.rungeKuttDatabaseDataGridView.AutoGenerateColumns = false;
            this.rungeKuttDatabaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rungeKuttDatabaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rungeKuttDatabaseDataGridView.DataSource = this.rungeKuttDatabaseBindingSource;
            this.rungeKuttDatabaseDataGridView.Location = new System.Drawing.Point(0, 28);
            this.rungeKuttDatabaseDataGridView.Name = "rungeKuttDatabaseDataGridView";
            this.rungeKuttDatabaseDataGridView.Size = new System.Drawing.Size(743, 214);
            this.rungeKuttDatabaseDataGridView.TabIndex = 1;
            this.rungeKuttDatabaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rungeKuttDatabaseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "x0";
            this.dataGridViewTextBoxColumn2.HeaderText = "x0";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "y0";
            this.dataGridViewTextBoxColumn3.HeaderText = "y0";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "y[0]";
            this.dataGridViewTextBoxColumn4.HeaderText = "y[0]";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "y[1]";
            this.dataGridViewTextBoxColumn5.HeaderText = "y[1]";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "y[2]";
            this.dataGridViewTextBoxColumn6.HeaderText = "y[2]";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "y[3]";
            this.dataGridViewTextBoxColumn7.HeaderText = "y[3]";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(84, 366);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(75, 23);
            this.Compute.TabIndex = 2;
            this.Compute.Text = "Вычислить";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.button1_Click);
            // 
            // xOTextBox
            // 
            this.xOTextBox.Location = new System.Drawing.Point(84, 284);
            this.xOTextBox.Name = "xOTextBox";
            this.xOTextBox.Size = new System.Drawing.Size(100, 20);
            this.xOTextBox.TabIndex = 3;
            this.xOTextBox.Text = "0";
            this.xOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xOTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yOtextBox
            // 
            this.yOtextBox.Location = new System.Drawing.Point(84, 324);
            this.yOtextBox.Name = "yOtextBox";
            this.yOtextBox.Size = new System.Drawing.Size(100, 20);
            this.yOtextBox.TabIndex = 4;
            this.yOtextBox.Text = "0";
            this.yOtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yOtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // xOLabel
            // 
            this.xOLabel.AutoSize = true;
            this.xOLabel.Location = new System.Drawing.Point(34, 290);
            this.xOLabel.Name = "xOLabel";
            this.xOLabel.Size = new System.Drawing.Size(18, 13);
            this.xOLabel.TabIndex = 5;
            this.xOLabel.Text = "x0\r\n";
            // 
            // yOLabel
            // 
            this.yOLabel.AutoSize = true;
            this.yOLabel.Location = new System.Drawing.Point(37, 330);
            this.yOLabel.Name = "yOLabel";
            this.yOLabel.Size = new System.Drawing.Size(18, 13);
            this.yOLabel.TabIndex = 6;
            this.yOLabel.Text = "y0";
            this.yOLabel.Click += new System.EventHandler(this.yOLabel_Click);
            // 
            // RungeKutt_Metods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 454);
            this.Controls.Add(this.yOLabel);
            this.Controls.Add(this.xOLabel);
            this.Controls.Add(this.yOtextBox);
            this.Controls.Add(this.xOTextBox);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.rungeKuttDatabaseDataGridView);
            this.Controls.Add(this.rungeKuttDatabaseBindingNavigator);
            this.Name = "RungeKutt_Metods";
            this.Text = "RungeKutt_Metods";
            this.Load += new System.EventHandler(this.RungeKutt_Metods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseRungeKutt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseBindingNavigator)).EndInit();
            this.rungeKuttDatabaseBindingNavigator.ResumeLayout(false);
            this.rungeKuttDatabaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rungeKuttDatabaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseRungeKutt databaseRungeKutt;
        private System.Windows.Forms.BindingSource rungeKuttDatabaseBindingSource;
        private DatabaseRungeKuttTableAdapters.RungeKuttDatabaseTableAdapter rungeKuttDatabaseTableAdapter;
        private DatabaseRungeKuttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rungeKuttDatabaseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rungeKuttDatabaseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rungeKuttDatabaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.TextBox xOTextBox;
        private System.Windows.Forms.TextBox yOtextBox;
        private System.Windows.Forms.Label xOLabel;
        private System.Windows.Forms.Label yOLabel;
    }
}