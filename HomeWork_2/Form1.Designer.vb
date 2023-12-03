<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТапшырмаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТапшырмаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТапшырмаToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТапшырмаToolStripMenuItem, Me.ТапшырмаToolStripMenuItem1, Me.ТапшырмаToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 26)
        Me.ToolStripMenuItem1.Text = "Тапшырманы танда"
        '
        'ТапшырмаToolStripMenuItem
        '
        Me.ТапшырмаToolStripMenuItem.Name = "ТапшырмаToolStripMenuItem"
        Me.ТапшырмаToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ТапшырмаToolStripMenuItem.Text = "1-тапшырма"
        '
        'ТапшырмаToolStripMenuItem1
        '
        Me.ТапшырмаToolStripMenuItem1.Name = "ТапшырмаToolStripMenuItem1"
        Me.ТапшырмаToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.ТапшырмаToolStripMenuItem1.Text = "2-тапшырма"
        '
        'ТапшырмаToolStripMenuItem2
        '
        Me.ТапшырмаToolStripMenuItem2.Name = "ТапшырмаToolStripMenuItem2"
        Me.ТапшырмаToolStripMenuItem2.Size = New System.Drawing.Size(180, 26)
        Me.ТапшырмаToolStripMenuItem2.Text = "3-тапшырма"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Алибеков Нуртилек 2004.01013"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ТапшырмаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ТапшырмаToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ТапшырмаToolStripMenuItem2 As ToolStripMenuItem
End Class
