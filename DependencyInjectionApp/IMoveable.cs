namespace InterfacesApp;

    internal interface IMoveable
    {
        void Move5();
        
        // Default Implementation  
        void Move10()
        {
            Console.WriteLine("Move 10 units");
        }
    }