# PanelMaster
Tools for creating precast in Revit 2019

![Интерфейс](/img/overview.png)

## Установка

Скопировать содержимое директории
> \\\ir-dsk\DNSDevelopment\1_ДСК Приморье\13. Проектный институт\ДНС ПРОЕКТ РАБОЧАЯ\BIM\00_DNSPanel\11_МастерПанелей\v2019

В директорию

> C:\Users\\{username}\AppData\Roaming\Autodesk\Revit\Addins\2019

***{username}** заменить на актуальное имя пользователя*

Запустить **Revit 2019**, при появлении окна выбрать опцию ***"Всегда разрешать"***

## Описание функций
Запуск процедур производится из вкладки "Мастер панелей" в ленте

![КЖ - LOD 100](/img/lod_100.png)

1. **Создание проекта КЖ**
   - Создание проемов по файлу АР
   - Создание марок изделия
   - Создание сборок изделия
   - Разборке сборок изделий

![КЖ - LOD 400](/img/lod_400.png)

2. **Создание проекта КЖ.И**
   - Удалению уникальных сборок
   - Созданию чертежей изделий

![АКР](/img/arch.png)

3. **Создание проекта АР и АКР**
   - Создание проемов по файлу КР
   - Создание плитки
   - Создание марок фасадов (по материалам плитки и файлу КР)
   - Создание чертежей фасадов

![АКР](/img/settings.png)

4. **Задания настроек**
   - Правило выбора элементов
   - Способ раскладки плитки
   - Габариты плитки

## Перед началом

## Работа процедур
### КЖ - Создание проемов
*Принцип работы: собирает коллекцию подгруженных АР подложек (**Важно:** файлы АР должны быть подргужены напрямую и содержать подстроку "_АР" в названии).*

*Для каждой выбранной панели типа НС или ВС ищет список окон, пересекающих BoundingBox панели (категория: Окна, имя содержит "DNS_").*

*Если список пустой, то ищет список дверей, пересекающих BoundingBox панели (категория: Двери, имя не содержит "стекл").*

*Длина списка 0 <= n <= 2; при n>2 последний элемент отбрасывается (В семействах панелей не заложено создание 3 отверстия).*

***Если панель пересекает И дверь (категория: дверь) И окно (категория: окно), то будет создан проем только для окна. Это - ошибка, которая будет устранена***

*Из списка окон/дверей считываются системные параметры высоты и ширины. Они копируются в значения параметров панели с учётом модуля 300мм, шага плитки 12мм, и смещения уровня -80мм. На данный момент не предусмотрено изменение этих параметров.*

### КЖ - Создание марок
*Принцип работы: собирает коллекцию панелей*

*Для каждой выбранной панели проверяет создает значения параметров **"DNS_Полная_марка_изделия"**, **"ADSK_Марка_изделия"** и считывает параметр **"ADSK_Номер_изделия"**.*

*Если **"ADSK_Номер_изделия"** пустой, то создаёт индекс вида "ID{element.Id}"*

*Для корректного назначения марок необходимо вручную проставить индексы в **"ADSK_Номер_изделия"**, очистить параметры **"DNS_Полная_марка_изделия"** и **"ADSK_Марка_изделия"** и выполнить процедуру заново*

*В будущем выбор переписывать или нет значения марок будет добавлен в настройки*

### КЖ - Создание сборок
*Принцип работы: Для выбранного набора элементов *
**
**
**
**
