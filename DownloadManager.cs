# ExtensionMethods
Extension Methods
public static class DownloadManager
{
      public static void Download(this Book book)
      {
        ....
      }
}
DownloadManager.Download(book);
Download(book);
book.Download();
