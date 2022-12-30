<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ventes_vbDataSet = New LoginForm.ventes_vbDataSet()
        Me.ArticleTableAdapter = New LoginForm.ventes_vbDataSetTableAdapters.articleTableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ArticleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ventes_vbDataSet1 = New LoginForm.ventes_vbDataSet1()
        Me.ArticleTableAdapter1 = New LoginForm.ventes_vbDataSet1TableAdapters.articleTableAdapter()
        Me.Ventes_vbDataSet2 = New LoginForm.ventes_vbDataSet2()
        Me.ArticleBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticleTableAdapter2 = New LoginForm.ventes_vbDataSet2TableAdapters.articleTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ventes_vbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ventes_vbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ventes_vbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Avigea", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vendre Un Produit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Avigea", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Liste Des Articles"
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ArticleBindingSource
        Me.ListBox1.DisplayMember = "LIBELLE"
        Me.ListBox1.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(175, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 124)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.ValueMember = "PRIXDEVENTE"
        '
        'ArticleBindingSource
        '
        Me.ArticleBindingSource.DataMember = "article"
        Me.ArticleBindingSource.DataSource = Me.Ventes_vbDataSet
        '
        'Ventes_vbDataSet
        '
        Me.Ventes_vbDataSet.DataSetName = "ventes_vbDataSet"
        Me.Ventes_vbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticleTableAdapter
        '
        Me.ArticleTableAdapter.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.ArticleBindingSource
        Me.ListBox2.DisplayMember = "QUANTITESTOCK"
        Me.ListBox2.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 24
        Me.ListBox2.Location = New System.Drawing.Point(401, 113)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(133, 124)
        Me.ListBox2.TabIndex = 7
        Me.ListBox2.ValueMember = "QUANTITESTOCK"
        '
        'ListBox3
        '
        Me.ListBox3.DataSource = Me.ArticleBindingSource
        Me.ListBox3.DisplayMember = "PRIXDEVENTE"
        Me.ListBox3.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 24
        Me.ListBox3.Location = New System.Drawing.Point(581, 113)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(133, 124)
        Me.ListBox3.TabIndex = 8
        Me.ListBox3.ValueMember = "PRIXDEVENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Libelle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Prix"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(255, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Enregistrer La vente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(260, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Libelle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Avigea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Quantite"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ArticleBindingSource1
        Me.ComboBox1.DisplayMember = "LIBELLE"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 325)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "LIBELLE"
        '
        'ArticleBindingSource1
        '
        Me.ArticleBindingSource1.DataMember = "article"
        Me.ArticleBindingSource1.DataSource = Me.Ventes_vbDataSet1
        '
        'Ventes_vbDataSet1
        '
        Me.Ventes_vbDataSet1.DataSetName = "ventes_vbDataSet1"
        Me.Ventes_vbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticleTableAdapter1
        '
        Me.ArticleTableAdapter1.ClearBeforeFill = True
        '
        'Ventes_vbDataSet2
        '
        Me.Ventes_vbDataSet2.DataSetName = "ventes_vbDataSet2"
        Me.Ventes_vbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticleBindingSource2
        '
        Me.ArticleBindingSource2.DataMember = "article"
        Me.ArticleBindingSource2.DataSource = Me.Ventes_vbDataSet2
        '
        'ArticleTableAdapter2
        '
        Me.ArticleTableAdapter2.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 325)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 21)
        Me.TextBox1.TabIndex = 22
        '
        'vendre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(761, 442)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vendre"
        Me.Text = "vendre"
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ventes_vbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ventes_vbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ventes_vbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Ventes_vbDataSet As LoginForm.ventes_vbDataSet
    Friend WithEvents ArticleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticleTableAdapter As LoginForm.ventes_vbDataSetTableAdapters.articleTableAdapter
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ventes_vbDataSet1 As LoginForm.ventes_vbDataSet1
    Friend WithEvents ArticleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ArticleTableAdapter1 As LoginForm.ventes_vbDataSet1TableAdapters.articleTableAdapter
    Friend WithEvents Ventes_vbDataSet2 As LoginForm.ventes_vbDataSet2
    Friend WithEvents ArticleBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ArticleTableAdapter2 As LoginForm.ventes_vbDataSet2TableAdapters.articleTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
