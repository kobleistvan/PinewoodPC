
Public Class Form2
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        MaskedTextBox1.Select()

        Timer1.Stop()

        Label14.Text = "0"
        Label13.Text = "0"
        Label10.Text = "0"
        Label11.Text = "0"
        Label12.Text = "0"
        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label9.Text = "0"

        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()
        Label19.Hide()
        Label20.Hide()
        Label22.Hide()
        Label23.Hide()

        Button2.Enabled = True



    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.Close()
        Me.Close()

        Dialog1.Close()
        AboutBox1.Close()
    End Sub


    Private Sub PinewoodPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PinewoodPCToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        keybd_event(VK_SCROLL, 0, 0, 0) 'Press Scroll Lock
        keybd_event(VK_SCROLL, 0, KEYEVENTF_KEYUP, 0) 'Release Scroll Lock
        Sleep(200) 'Wait a bit
        keybd_event(VK_SCROLL, 0, 0, 0) 'Press Scroll Lock
        keybd_event(VK_SCROLL, 0, KEYEVENTF_KEYUP, 0) 'Release Scroll Lock

        MaskedTextBox1.Select()

        Timer1.Start()


        Button2.Enabled = False


    End Sub


    Private Declare Sub keybd_event Lib "user32.dll" _
    (ByVal bVk As Byte, ByVal bScan As Byte, _
    ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Private Declare Sub Sleep Lib "kernel32" _
    (ByVal dwMilliseconds As Long)

    Const VK_SCROLL = &H91
    Const KEYEVENTF_KEYUP = &H2



    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)
        Activate()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()
        Label19.Hide()
        Label20.Hide()
        Label22.Hide()
        Label23.Hide()

        MaskedTextBox1.Select()

    End Sub



    Private Sub MaskedTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.TextChanged
        If MaskedTextBox1.MaxLength Then
            Label9.Text = Label14.Text
            Label10.Text = Label13.Text
            Label9.Show()
            Label10.Show()
            Label23.Show()

            MaskedTextBox2.Select()


        End If

    End Sub
    Private Sub MaskedTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.TextChanged
        If MaskedTextBox2.MaxLength Then
            Label11.Text = Label14.Text
            Label12.Text = Label13.Text
            Label11.Show()
            Label12.Show()
            Label22.Show()
            MaskedTextBox3.Select()

        End If

    End Sub
    Private Sub MaskedTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox3.TextChanged
        If MaskedTextBox3.MaxLength Then
            Label15.Text = Label14.Text
            Label16.Text = Label13.Text
            Label15.Show()
            Label16.Show()
            Label20.Show()
            MaskedTextBox4.Select()

        End If

    End Sub

    Private Sub MaskedTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox4.TextChanged
        If MaskedTextBox4.MaxLength Then
            Label17.Text = Label14.Text
            Label18.Text = Label13.Text
            Label17.Show()
            Label18.Show()
            Label19.Show()
            Timer1.Stop()

        End If

    End Sub

    Dim tmr1 As Integer
    Dim tmr2 As Integer
    Dim tmr3 As Integer
    Dim tmr4 As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tmr1 = tmr1 + 1
        Label13.Text = tmr1
        If tmr1 = 9 Then
            Label14.Text = Label14.Text + 1
            tmr1 = 0
        End If
        If Label14.Text = 9 Then
            Timer1.Stop()
            If MaskedTextBox1.Text = "" Then
                MaskedTextBox1.Text = "0"
            End If
            If MaskedTextBox2.Text = "" Then
                MaskedTextBox2.Text = "0"

            End If
            If MaskedTextBox3.Text = "" Then
                MaskedTextBox3.Text = "0"

            End If
            If MaskedTextBox4.Text = "" Then
                MaskedTextBox4.Text = "0"

            End If
        End If
    End Sub



    Private Sub ÚtmutatásToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÚtmutatásToolStripMenuItem.Click
        Dialog1.Show()

    End Sub



    Private Sub MagyarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagyarToolStripMenuItem.Click
        Me.MagyarToolStripMenuItem.Checked = True
        Me.AngolToolStripMenuItem.Checked = False

        Me.NyelvToolStripMenuItem.Text = "Nyelv"
        Me.FileToolStripMenuItem.Text = "Fájl"
        Me.AboutToolStripMenuItem.Text = "Segítség"
        Me.ExitToolStripMenuItem.Text = "Kilépés"
        Me.ÚtmutatásToolStripMenuItem.Text = "Útmutatás"
        Me.PinewoodPCToolStripMenuItem.Text = "Pinewood PC-ről"
        Me.MagyarToolStripMenuItem.Text = "Magyar"
        Me.AngolToolStripMenuItem.Text = "Angol"
        Me.Button1.Text = "Következő futam"
        Me.Label5.Text = "Sáv"
        Me.Label6.Text = "Sáv"
        Me.Label7.Text = "Sáv"
        Me.Label8.Text = "Sáv"
        Me.Label1.Text = "l. Hely"
        Me.Label2.Text = "ll. Hely"
        Me.Label3.Text = "lll. Hely"
        Me.Label4.Text = "lV. Hely"
        Dialog1.TextBox1.Text = "A START gomb elindítja a stopperórát és a kocsikat."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "A KÖVETKEZŐ FUTAM gomb lenullázza a stopperórát és kitőrli az elöző futamban nyert adatokat."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "A kocsi beérkezésénél a hozzá illő stopper leáll. A programhoz illő műszer automatikusan betáplálja a sávok számát a kocsik beérkezésénél."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "A műszernek szükséges egy működő 2.0 USB port."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "A program műkődéséért a NUM LOCK gomb illetve billentyüzeten lévő LED kötelező, hogy aktív legyen!"
        Dialog1.Text = "Útmutatás"
        Dialog1.Button1.Text = "Értettem"

        AboutBox1.Label1.Text = "A Pinewood PC egy számitógép program, amely a cserkészetbeli Pinewood Derby kisautó versenynek van szánva. A program optimális műkődéséért ajánolva van a hozzá illő hardware használata. Készitette Köble István   A.K.A. PityX       Minden jog fenntartva"


         End Sub

    Private Sub AngolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngolToolStripMenuItem.Click
        Me.MagyarToolStripMenuItem.Checked = False
        Me.AngolToolStripMenuItem.Checked = True

        Me.NyelvToolStripMenuItem.Text = "Language"
        Me.FileToolStripMenuItem.Text = "File"
        Me.AboutToolStripMenuItem.Text = "Help"
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ÚtmutatásToolStripMenuItem.Text = "Instructions"
        Me.PinewoodPCToolStripMenuItem.Text = "About Pinewood PC"
        Me.MagyarToolStripMenuItem.Text = "Hungarian"
        Me.AngolToolStripMenuItem.Text = "English"
        Me.Button1.Text = "Next race"
        Me.Label5.Text = "Lane"
        Me.Label6.Text = "Lane"
        Me.Label7.Text = "Lane"
        Me.Label8.Text = "Lane"

        Me.Label1.Text = "1st Place"
        Me.Label2.Text = "2nd Place"
        Me.Label3.Text = "3rd Place"
        Me.Label4.Text = "4th Place"

        Dialog1.TextBox1.Text = "The START button starts the timers and the cars."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "The NEXT RACE button resets the timers and the previous results."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "When a car crosses the finish line, it's timer stops automatically. The module of this software automatically inputs the number of the lanes at the arriving of the cars."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "The module requires a functional 2.0 USB port."
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += Environment.NewLine
        Dialog1.TextBox1.Text += "For the proper operation of this program, the NUM LOCK key must be turned on!"
        Dialog1.Text = "Instructions"
        Dialog1.Button1.Text = "Got it"
        AboutBox1.Label1.Text = "Pinewood PC is a computer software specially developed for Pinewood Derby racing in scouting.  For the optimal behaviour of the software, the use of a hardware, specially developed for it is recommended. Created,and developed by Köble István   A.K.A. PityX       All rights reserved"
    End Sub
End Class
