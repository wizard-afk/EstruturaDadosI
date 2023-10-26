
using LinkedList;

Page pageFirst = new Page() { Content = "Atualmente..." };
Page pageSecond = new Page() { Content = "Aplicação..."};
Page pageThird = new Page() { Content = "Muito de..."};

Page pageFourth = new Page() { Content = "Você sabia...", PageNumber = 4};
pageFourth.PageNumber = 4;

Page pageFifth = new Page() { 
    Content = "Enquanto...",
    PageNumber = 5
};

Page pageSixth = new Page();
pageSixth.Content = "Você poderia...";
pageSixth.PageNumber = 6;

var pageSeventh = new Page();
pageSeventh.Content = "Era uma vez...";
pageSeventh.PageNumber = 7;

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page> nodePageFourth = 
    pages.AddLast(pageFourth);
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);

pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

