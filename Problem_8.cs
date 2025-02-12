using System;

class TextStateNode
{
    public string TextContent { get; set; }
    public TextStateNode Prev { get; set; }
    public TextStateNode Next { get; set; }

    public TextStateNode(string textContent)
    {
        TextContent = textContent;
        Prev = null;
        Next = null;
    }
}

class TextEditorHistory
{
    private TextStateNode currentState;
    private int historySize;
    private int stateCount;

    public TextEditorHistory(int size)
    {
        currentState = null;
        historySize = size;
        stateCount = 0;
    }

    // Add a new text state at the end of the list
    public void AddState(string textContent)
    {
        TextStateNode newState = new TextStateNode(textContent);

        // If there's a current state, remove all redo states
        if (currentState != null)
        {
            currentState.Next = null;
        }

        newState.Prev = currentState;
        currentState = newState;

        stateCount++;
        TrimHistory();

        Console.WriteLine("State added: " + textContent);
    }

    // Undo functionality (revert to the previous state)
    public void Undo()
    {
        if (currentState == null || currentState.Prev == null)
        {
            Console.WriteLine("No previous state to undo.");
            return;
        }

        currentState = currentState.Prev;
        Console.WriteLine("Undo performed. Current state: " + currentState.TextContent);
    }

    // Redo functionality (revert back to the next state after undo)
    public void Redo()
    {
        if (currentState == null || currentState.Next == null)
        {
            Console.WriteLine("No next state to redo.");
            return;
        }

        currentState = currentState.Next;
        Console.WriteLine("Redo performed. Current state: " + currentState.TextContent);
    }

    // Display the current state of the text
    public void DisplayCurrentState()
    {
        if (currentState == null)
        {
            Console.WriteLine("No current state available.");
        }
        else
        {
            Console.WriteLine("Current state: " + currentState.TextContent);
        }
    }

    // Limit the undo/redo history to a fixed size
    private void TrimHistory()
    {
        if (stateCount > historySize)
        {
            // Find the oldest state to trim
            TextStateNode oldest = currentState;
            while (oldest.Prev != null)
            {
                oldest = oldest.Prev;
            }

            // Remove the oldest node
            oldest.Next.Prev = null;
            stateCount--;
        }
    }

    public static void Main(string[] args)
    {
        TextEditorHistory editor = new TextEditorHistory(10);

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.DisplayCurrentState();

        editor.Undo();
        editor.Undo();
        editor.Redo();

        editor.DisplayCurrentState();
    }
}