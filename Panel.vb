
Dim NumbOfItems As Integer = 2
        Dim Panel(NumbOfItems - 1) As Panel 'Creates an array of panels with as many panels as you have NumbOfItems set as.
        For i = 0 To Panel.Length - 1 'For every panel
            Panel(i) = New Panel 'This initialises the Panel AS a panel
            With Panel(i)
                .Size = New Size(100, 100) 'This makes it 100 by 100 (pixels)
                .Location = New Point(100, 100 * i) 'This sets the position (I've gone for 100x, 100i y)
                .BorderStyle = BorderStyle.FixedSingle 'This sets the border of the panel.
                Me.Controls.Add(Panel(i)) 'This adds the Panel to the form.
            End With
Next
