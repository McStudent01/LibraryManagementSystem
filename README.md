# LibraryManagementSystem
```mermaid 
flowchart TB
    subgraph frontend ["Front-End (Blazor)"]
        bookList["Book List Screen"]
        bookDetails["Book Details Screen"]
        addBook["Add Book Screen"]
        editBook["Edit Book Screen"]
        searchBook["Search Book Screen"]
    end

    subgraph api ["Minimal API"]
        getAllBooks["GET /books - All books"]
        getBookByID["GET /books/{id} - Book by ID"]
        postBook["POST /books - Add new book"]
        putBook["PUT /books/{id} - Update book"]
        deleteBook["DELETE /books/{id} - Delete book"]
    end

    subgraph db ["Database"]
        books["Books Table"]
        authors["Authors Table"]
        genres["Genres Table"]
        publishers["Publishers Table"]
        reviews["Reviews Table"]
    end

    bookList -->|GET all books| getAllBooks
    bookDetails -->|GET book by ID| getBookByID
    addBook -->|POST new book| postBook
    editBook -->|PUT update book| putBook
    searchBook -->|Search API| getAllBooks

    getAllBooks -->|Read| books
    getBookByID -->|Read| books
    postBook -->|Create| books
    putBook -->|Update| books
    deleteBook -->|Delete| books

    books -->|Foreign Key| authors
    books -->|Foreign Key| genres
    books -->|Foreign Key| publishers
    books -->|Foreign Key| reviews

    classDef screen fill:#f9f,stroke:#333,stroke-width:2px;
    classDef api fill:#ccf,stroke:#333,stroke-width:2px;
    classDef db fill:#cfc,stroke:#333,stroke-width:2px;
    class frontend,api,db screen;

    ```