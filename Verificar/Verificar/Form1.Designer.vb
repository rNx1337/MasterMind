<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtchave = New System.Windows.Forms.TextBox()
        Me.butnova = New System.Windows.Forms.Button()
        Me.cbt1 = New System.Windows.Forms.ComboBox()
        Me.cbt2 = New System.Windows.Forms.ComboBox()
        Me.cbt3 = New System.Windows.Forms.ComboBox()
        Me.cbt4 = New System.Windows.Forms.ComboBox()
        Me.butverificar = New System.Windows.Forms.Button()
        Me.txtverificacao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chave :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tentiva : "
        '
        'txtchave
        '
        Me.txtchave.Location = New System.Drawing.Point(58, 23)
        Me.txtchave.Name = "txtchave"
        Me.txtchave.Size = New System.Drawing.Size(100, 20)
        Me.txtchave.TabIndex = 2
        '
        'butnova
        '
        Me.butnova.Location = New System.Drawing.Point(174, 22)
        Me.butnova.Name = "butnova"
        Me.butnova.Size = New System.Drawing.Size(75, 23)
        Me.butnova.TabIndex = 3
        Me.butnova.Text = "Nova"
        Me.butnova.UseVisualStyleBackColor = True
        '
        'cbt1
        '
        Me.cbt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbt1.FormattingEnabled = True
        Me.cbt1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbt1.Location = New System.Drawing.Point(71, 76)
        Me.cbt1.Name = "cbt1"
        Me.cbt1.Size = New System.Drawing.Size(39, 21)
        Me.cbt1.TabIndex = 4
        '
        'cbt2
        '
        Me.cbt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbt2.FormattingEnabled = True
        Me.cbt2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbt2.Location = New System.Drawing.Point(119, 76)
        Me.cbt2.Name = "cbt2"
        Me.cbt2.Size = New System.Drawing.Size(39, 21)
        Me.cbt2.TabIndex = 5
        '
        'cbt3
        '
        Me.cbt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbt3.FormattingEnabled = True
        Me.cbt3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbt3.Location = New System.Drawing.Point(164, 77)
        Me.cbt3.Name = "cbt3"
        Me.cbt3.Size = New System.Drawing.Size(39, 21)
        Me.cbt3.TabIndex = 6
        '
        'cbt4
        '
        Me.cbt4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbt4.FormattingEnabled = True
        Me.cbt4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cbt4.Location = New System.Drawing.Point(209, 77)
        Me.cbt4.Name = "cbt4"
        Me.cbt4.Size = New System.Drawing.Size(39, 21)
        Me.cbt4.TabIndex = 7
        '
        'butverificar
        '
        Me.butverificar.Location = New System.Drawing.Point(25, 140)
        Me.butverificar.Name = "butverificar"
        Me.butverificar.Size = New System.Drawing.Size(75, 23)
        Me.butverificar.TabIndex = 8
        Me.butverificar.Text = "Verificar"
        Me.butverificar.UseVisualStyleBackColor = True
        '
        'txtverificacao
        '
        Me.txtverificacao.Location = New System.Drawing.Point(119, 142)
        Me.txtverificacao.Name = "txtverificacao"
        Me.txtverificacao.Size = New System.Drawing.Size(130, 20)
        Me.txtverificacao.TabIndex = 9
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 193)
        Me.Controls.Add(Me.txtverificacao)
        Me.Controls.Add(Me.butverificar)
        Me.Controls.Add(Me.cbt4)
        Me.Controls.Add(Me.cbt3)
        Me.Controls.Add(Me.cbt2)
        Me.Controls.Add(Me.cbt1)
        Me.Controls.Add(Me.butnova)
        Me.Controls.Add(Me.txtchave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form1"
        Me.Text = "MasterMind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtchave As System.Windows.Forms.TextBox
    Friend WithEvents butnova As System.Windows.Forms.Button
    Friend WithEvents cbt1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbt2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbt3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbt4 As System.Windows.Forms.ComboBox
    Friend WithEvents butverificar As System.Windows.Forms.Button
    Friend WithEvents txtverificacao As System.Windows.Forms.TextBox

End Class
