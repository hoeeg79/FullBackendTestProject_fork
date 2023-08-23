using infrastructure;
using infrastructure.DataModels;

namespace service;

public class Service
{
    private readonly Repository _repository;

    public Service(Repository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        try
        {
            return _repository.GetAllBooks();
        }
        catch (Exception)
        {
            throw new Exception("Could not get books");
        }
    }

    public Book CreateBook(Book book)
    {
        try
        {
            return _repository.CreateBook(book);
        }
        catch (Exception e)
        {
            throw new Exception("Could not create book");
        }
    }

    public Book UpdateBook(Book book, int bookId)
    {
        try
        {
            return _repository.UpdateBook(book, bookId);
        }
        catch (Exception e)
        {
            throw new Exception("Could not update book");
        }
    }

    public object DeleteBook(int bookId)
    {
        try
        {
            return _repository.DeleteBook(bookId);
        }
        catch (Exception e)
        {
            throw new Exception("Could not delete book");
        }
    }
}