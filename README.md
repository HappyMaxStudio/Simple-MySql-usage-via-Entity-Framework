Просто консольное приложение, создающее и использующее небольшую базу данных, состоящую из 10-ти действующих игроков Национальной Футбольной Лиги(NFL).</br>
Сначала удаляется прошлая база, на её месте создается новая, отображается список игрков в ней, далее предлагается добавить легендарного Дэна Марино из фильма "Эйс Вентура. Поиск домашних животных". Далее идёт сортировка и группировка по различным параметрам. </br>
В коде можно увидеть простые моменты работы с БД, такие как: создание контекста для работы с БД, определение модели, сущности. Кроме того, через Fluent API: исключение свойства, сопоставление столбца со свойством, необязательные свойства, индекс,  генерация значений свойств, их ограничение, инициализация данными в OnModelCreating(), плюс вынесение всех этих моментов в отдельную конфигурацию. Ну и, само собой, сортировка и группировка. Вывод данных происходил из списков, созданных из основного списка в БД, изменение в итоговом файле players.db произошло только при добавлении Дэна Марино. </br>
![players](https://github.com/HappyMaxStudio/Simple-MySql-usage-via-Entity-Framework/assets/116747009/3864c337-589b-465a-90f0-f4d097d367b0)
