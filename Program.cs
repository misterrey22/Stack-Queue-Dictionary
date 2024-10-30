using System;
using System.Collections.Generic;


// ЗАВДАННЯ 1 (Керування стеком документів)


class Program
{
    static void Main()
    {
        // Створення стеку для документів
        Stack<Document> documentStack = new Stack<Document>();

        // Додавання документів до стеку
        AddDocumentToStack(documentStack, new Document("Document1", "Content1"));
        AddDocumentToStack(documentStack, new Document("Document2", "Content2"));
        AddDocumentToStack(documentStack, new Document("Document3", "Content3"));

        // Виведення інформації про верхній документ у стеці
        PrintTopDocumentInfo(documentStack);

        // Видалення верхнього документу зі стеку
        RemoveTopDocument(documentStack);

        // Виведення інформації про новий верхній документ у стеці
        PrintTopDocumentInfo(documentStack);
    }

    // Функція для додавання нового документу до стеку
    static void AddDocumentToStack(Stack<Document> stack, Document document)
    {
        stack.Push(document);
        Console.WriteLine($"Документ \"{document.Title}\" додано до стеку.");
    }

    // Функція для видалення верхнього документу зі стеку
    static void RemoveTopDocument(Stack<Document> stack)
    {
        if (stack.Count > 0)
        {
            Document removedDocument = stack.Pop();
            Console.WriteLine($"Верхній документ \"{removedDocument.Title}\" видалено зі стеку.");
        }
        else
        {
            Console.WriteLine("Стек документів порожній. Неможливо видалити документ.");
        }
    }

    // Функція для отримання верхнього документу зі стеку без його видалення
    static void PrintTopDocumentInfo(Stack<Document> stack)
    {
        if (stack.Count > 0)
        {
            Document topDocument = stack.Peek();
            Console.WriteLine($"Інформація про верхній документ: {topDocument}");
        }
        else
        {
            Console.WriteLine("Стек документів порожній. Неможливо отримати інформацію.");
        }
    }
}

// Клас, що представляє документ
class Document
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public override string ToString()
    {
        return $"Назва: {Title}, Вміст: {Content}";
    }
}



// ЗАВДАННЯ 2 (Керування чергою замовлень)


class Program
{
    static void Main()
    {
        // Створення черги для замовлень
        Queue<Order> orderQueue = new Queue<Order>();

        // Додавання замовлень до черги
        AddOrderToQueue(orderQueue, new Order("Order1", "Burger"));
        AddOrderToQueue(orderQueue, new Order("Order2", "Pizza"));
        AddOrderToQueue(orderQueue, new Order("Order3", "Salad"));

        // Виведення інформації про найстарше замовлення у черзі
        PrintOldestOrderInfo(orderQueue);

        // Видалення найстаршого замовлення з черги
        RemoveOldestOrder(orderQueue);

        // Виведення інформації про нове найстарше замовлення у черзі
        PrintOldestOrderInfo(orderQueue);
    }

    // Функція для додавання нового замовлення до черги
    static void AddOrderToQueue(Queue<Order> queue, Order order)
    {
        queue.Enqueue(order);
        Console.WriteLine($"Замовлення \"{order.OrderName}\" додано до черги.");
    }

    // Функція для видалення найстаршого замовлення з черги
    static void RemoveOldestOrder(Queue<Order> queue)
    {
        if (queue.Count > 0)
        {
            Order removedOrder = queue.Dequeue();
            Console.WriteLine($"Найстарше замовлення \"{removedOrder.OrderName}\" видалено з черги.");
        }
        else
        {
            Console.WriteLine("Черга замовлень порожня. Неможливо видалити замовлення.");
        }
    }

    // Функція для отримання найстаршого замовлення з черги без його видалення
    static void PrintOldestOrderInfo(Queue<Order> queue)
    {
        if (queue.Count > 0)
        {
            Order oldestOrder = queue.Peek();
            Console.WriteLine($"Інформація про найстарше замовлення: {oldestOrder}");
        }
        else
        {
            Console.WriteLine("Черга замовлень порожня. Неможливо отримати інформацію.");
        }
    }
}

// Клас, що представляє замовлення
class Order
{
    public string OrderName { get; set; }
    public string Item { get; set; }

    public Order(string orderName, string item)
    {
        OrderName = orderName;
        Item = item;
    }

    public override string ToString()
    {
        return $"Назва замовлення: {OrderName}, Позиція: {Item}";
    }
}


//ЗАВДАННЯ 3 (Магазин книг зі словником книг)



class Program
{
    static void Main()
    {
        // Створення словника для каталогу книг
        Dictionary<int, Book> bookCatalog = new Dictionary<int, Book>();

        // Додавання книг до словника
        AddBookToCatalog(bookCatalog, new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        AddBookToCatalog(bookCatalog, new Book(2, "To Kill a Mockingbird", "Harper Lee"));
        AddBookToCatalog(bookCatalog, new Book(3, "1984", "George Orwell"));

        // Отримання інформації про книгу за її унікальним ідентифікатором та виведення на екран
        PrintBookInfo(bookCatalog, 2);

        // Видалення книги зі словника за її унікальним ідентифікатором
        RemoveBookFromCatalog(bookCatalog, 1);

        // Виведення всіх книг у каталозі
        PrintAllBooks(bookCatalog);
    }

    // Функція для додавання нової книги до словника
    static void AddBookToCatalog(Dictionary<int, Book> catalog, Book book)
    {
        catalog.Add(book.Id, book);
        Console.WriteLine($"Книга \"{book.Title}\" додана до каталогу.");
    }

    // Функція для видалення книги зі словника за її унікальним ідентифікатором
    static void RemoveBookFromCatalog(Dictionary<int, Book> catalog, int bookId)
    {
        if (catalog.ContainsKey(bookId))
        {
            catalog.Remove(bookId);
            Console.WriteLine($"Книгу з ідентифікатором {bookId} видалено з каталогу.");
        }
        else
        {
            Console.WriteLine($"Книги з ідентифікатором {bookId} не знайдено в каталозі.");
        }
    }

    // Функція для отримання інформації про книгу зі словника за її унікальним ідентифікатором та виведення на екран
    static void PrintBookInfo(Dictionary<int, Book> catalog, int bookId)
    {
        if (catalog.ContainsKey(bookId))
        {
            Book book = catalog[bookId];
            Console.WriteLine($"Інформація про книгу з ідентифікатором {bookId}: {book}");
        }
        else
        {
            Console.WriteLine($"Книги з ідентифікатором {bookId} не знайдено в каталозі.");
        }
    }

    // Функція для виведення всіх книг у каталозі
    static void PrintAllBooks(Dictionary<int, Book> catalog)
    {
        Console.WriteLine("Усі книги у каталозі:");
        foreach (var book in catalog.Values)
        {
            Console.WriteLine(book);
        }
    }
}

// Клас, що представляє книгу
class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Назва: {Title}, Автор: {Author}";
    }
}