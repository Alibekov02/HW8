<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HW1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Number = New System.Windows.Forms.TextBox()
        Me.Sin = New System.Windows.Forms.Button()
        Me.Cos = New System.Windows.Forms.Button()
        Me.Tan = New System.Windows.Forms.Button()
        Me.Ctan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Бир сан киргиз"
        '
        'Number
        '
        Me.Number.Location = New System.Drawing.Point(269, 65)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(196, 22)
        Me.Number.TabIndex = 1
        '
        'Sin
        '
        Me.Sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sin.Location = New System.Drawing.Point(168, 159)
        Me.Sin.Name = "Sin"
        Me.Sin.Size = New System.Drawing.Size(95, 32)
        Me.Sin.TabIndex = 2
        Me.Sin.Text = "Sin"
        Me.Sin.UseVisualStyleBackColor = True
        '
        'Cos
        '
        Me.Cos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Cos.Location = New System.Drawing.Point(292, 159)
        Me.Cos.Name = "Cos"
        Me.Cos.Size = New System.Drawing.Size(95, 32)
        Me.Cos.TabIndex = 3
        Me.Cos.Text = "Cos"
        Me.Cos.UseVisualStyleBackColor = True
        '
        'Tan
        '
        Me.Tan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Tan.Location = New System.Drawing.Point(426, 159)
        Me.Tan.Name = "Tan"
        Me.Tan.Size = New System.Drawing.Size(95, 32)
        Me.Tan.TabIndex = 4
        Me.Tan.Text = "Tan"
        Me.Tan.UseVisualStyleBackColor = True
        '
        'Ctan
        '
        Me.Ctan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Ctan.Location = New System.Drawing.Point(554, 159)
        Me.Ctan.Name = "Ctan"
        Me.Ctan.Size = New System.Drawing.Size(95, 32)
        Me.Ctan.TabIndex = 5
        Me.Ctan.Text = "Ctan"
        Me.Ctan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Жыйынтык"
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(269, 272)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(196, 22)
        Me.Result.TabIndex = 7
        '
        'HW1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ctan)
        Me.Controls.Add(Me.Tan)
        Me.Controls.Add(Me.Cos)
        Me.Controls.Add(Me.Sin)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HW1"
        Me.Text = "1-Тапшырма"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Number As TextBox
    Friend WithEvents Sin As Button
    Friend WithEvents Cos As Button
    Friend WithEvents Tan As Button
    Friend WithEvents Ctan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Result As TextBox
End Class
