using lesson4;

building first = new building(1, 27, 9, 144, 4);

Console.WriteLine("Уникальный номер здания - " + first.Id);
Console.WriteLine("Высота - " + first.Height + "м");
Console.WriteLine("Этажность - " + first.FloorsNum);
Console.WriteLine("Количество квартир - " + first.FlatsNum);
Console.WriteLine("Количество подъездов - " + first.PodjezdNum);

Console.WriteLine("----");

Console.WriteLine("Высота этажа - " + first.floorHeight() + "м");
Console.WriteLine("Количество квартир в подъезде - " + first.podjezdFlatsNum());
Console.WriteLine("Количество квартир на этаже - " + first.floorFlatsNum());