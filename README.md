# Тестовое задание: «Чтение RSS ленты» чать 2


Требуется разработать приложение, выполняющие чтение, хранение, отображение новостей из RSS-лент.


Приложение должно состоять из компонентов:


- [Консольное приложение](https://github.com/PiterPoker/RssNewConsole), выполняющее чтение новостей из RSS-источников и сохраняющее их в БД
- [Web-приложение](https://github.com/PiterPoker/NewsRssWeb/tree/master/NewsRssWeb) - страница для отображения новостей из БД


Иные требования:


- Используйте технологии: С#, MVC, Entity Framework, LINQ to SQL
- При необходимости, предоставьте скрипт для инициализации БД
- Следует избегать дублирования кода


## Задание: Web-приложение (сайт) 


Разработайте Web-страницу для отображения ленты новостей в 2-х вариантах:

- Генерация страницы на сервере
- Динамическое обновление содержимого страницы с использованием AJAX


Внешний вид страницы:


![Image of Yaktocat](https://github.com/PiterPoker/NewsRssWeb/blob/master/newsFeed.png)


В поле «Название новости» выводите гиперссылку, при нажатии на которую в новом окне должна открываться новость из первоисточника.
Реализуйте пагинацию по 10 записей на странице. Использовать сторонние библиотеки не желательно.


[Перейти на сайт...](http://test-rss-by.gearhostpreview.com/)

