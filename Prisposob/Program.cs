TreeTypeFactory factory = new TreeTypeFactory();

Forest forest = new Forest(factory);

forest.Addoak(10, 20, 1.0f);
forest.Addoak(50, 80, 1.2f);
forest.Addoak(100, 40, 2.0f);

forest.Render();