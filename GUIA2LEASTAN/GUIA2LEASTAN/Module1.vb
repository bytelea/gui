Module Module1
    Public countdecimals As Integer

    Public user As String
    Public number1 As Single
    Public number2 As Single
    Public answer As Single
    Public arithmeticprocess As String
    Public aoperator As Integer

    Public numbers = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Public question = New String() {"What does GUI stand for?", "Which of the following is a primary advantage of using a GUI over a Command-Line Interface (CLI)?", "What is a 'widget' in GUI?", "Which of the following is NOT typically considered a GUI component?", "What is the main function of a menu in a GUI?", "Which GUI component is commonly used to group related options where only one can be selected at a time?", "What does the acronym WIMP stand for in GUI?", "Which of the following is a characteristic of a modal window in GUI?", "What is the purpose of tooltips in GUI?", "Which programming language is commonly associated with creating GUIs using the Tkinter library?"}
    Public answerA = New String() {"Graphical User Interface", "Requires less memory", "A small mechanical device", "Button", "To display advertisements", "Checkbox", "Windows", "Icons", "Menus", "Pointer", "It allows interaction with other windows while open", "To provide quick help or information when hovering over an element", "Java"}
    Public answerB = New String() {"General User Interaction", "Faster for experienced users", "A standardized display representation of a control", "Textbox", "To provide a list of options or commands", "Radio Button", "Wireless Internet Messaging Protocol", "It requires the user to interact with it before returning to the main application", "To increase the loading speed of the application", "C++"}
    Public answerC = New String() {"Graphical Unified Integration", "More intuitive for beginners", "Graphical Unified Integration", "Complier", "To minimize all open windows", "Dropdown List", "Web-based Interactive Media Platform", "It is always resizable", "To change the theme of the interface", "Python"}
    Public answerD = New String() {"General Utility Interface", "Consumes fewer system resources", "A programming language", "Checkbox", "To increase system performance", "Slider", "Windows", "Information", "Media", "Processes", "It cannot contain buttons or input fields", "To display error messages", "Ruby"}
    Public correct_answer = New String() {"Graphical User Interface", "More intuitive for beginners", "A standardized display representation of a control", "Compiler", "To provide a list of options or commands", "Radio Button", "Windows, Icons, Menus, Pointer", "It requires the user to interact with it before returning to the main application", "To provide quick help or information when hovering over an element", "Python"}
    Public answer_selected As String
    Public Score As Byte
    Public accumulator1 As Byte
    Public counter As Integer
    Public correct_A As String
    Public Q_count As Byte

End Module
