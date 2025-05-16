```mermaid

classDiagram
    class Program
    class Controller
    class _IView_
    class Player
    class PlayerOrder
    class CompareByName
    class UglyView

    class _IComparable_
    class _IComparer_


    CompareByName <-- Controller
    _IView_ <-- Controller
    Player <-- Controller
    PlayerOrder <-- Controller
    
    _IView_ <|-- UglyView
    Player <-- UglyView

    _IComparable_ <|.. Player

    _IComparer_ <|.. CompareByName

    Controller <-- Program
    UglyView <-- Program

```