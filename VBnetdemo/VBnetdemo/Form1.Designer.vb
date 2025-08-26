<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnAddWrite = New System.Windows.Forms.Button()
        Me.txtProvincename = New System.Windows.Forms.TextBox()
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.txtGDP = New System.Windows.Forms.TextBox()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuery = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(39, 66)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(196, 109)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Init"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnAddWrite
        '
        Me.btnAddWrite.Location = New System.Drawing.Point(303, 374)
        Me.btnAddWrite.Name = "btnAddWrite"
        Me.btnAddWrite.Size = New System.Drawing.Size(165, 82)
        Me.btnAddWrite.TabIndex = 1
        Me.btnAddWrite.Text = "AddWrite"
        Me.btnAddWrite.UseVisualStyleBackColor = True
        '
        'txtProvincename
        '
        Me.txtProvincename.Location = New System.Drawing.Point(62, 297)
        Me.txtProvincename.Name = "txtProvincename"
        Me.txtProvincename.Size = New System.Drawing.Size(100, 21)
        Me.txtProvincename.TabIndex = 2
        '
        'txtCityName
        '
        Me.txtCityName.Location = New System.Drawing.Point(197, 297)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.Size = New System.Drawing.Size(100, 21)
        Me.txtCityName.TabIndex = 2
        '
        'txtGDP
        '
        Me.txtGDP.Location = New System.Drawing.Point(310, 297)
        Me.txtGDP.Name = "txtGDP"
        Me.txtGDP.Size = New System.Drawing.Size(100, 21)
        Me.txtGDP.TabIndex = 2
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(439, 297)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(100, 21)
        Me.txtIndex.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "txtIndex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "txtGDP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "txtCityName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "txtProvincename"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(265, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(536, 230)
        Me.DataGridView1.TabIndex = 4
        '
        'BtnQuery
        '
        Me.BtnQuery.Location = New System.Drawing.Point(62, 374)
        Me.BtnQuery.Name = "BtnQuery"
        Me.BtnQuery.Size = New System.Drawing.Size(165, 82)
        Me.BtnQuery.TabIndex = 5
        Me.BtnQuery.Text = "Query"
        Me.BtnQuery.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 532)
        Me.Controls.Add(Me.BtnQuery)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIndex)
        Me.Controls.Add(Me.txtGDP)
        Me.Controls.Add(Me.txtCityName)
        Me.Controls.Add(Me.txtProvincename)
        Me.Controls.Add(Me.btnAddWrite)
        Me.Controls.Add(Me.btnInit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInit As Button
    Friend WithEvents btnAddWrite As Button
    Friend WithEvents txtProvincename As TextBox
    Friend WithEvents txtCityName As TextBox
    Friend WithEvents txtGDP As TextBox
    Friend WithEvents txtIndex As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnQuery As Button
End Class
