string[] fraude = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
    Console.WriteLine("Identificadores de pedidos potencialmente fraudulentos (empiezan con 'B'):");
        foreach (string orderId in fraude)
        {
            if (orderId.StartsWith("B"))
            {
                Console.WriteLine(orderId);
            }
        }