using SmartHome;

MobilePhone mobile = new MobilePhone("AdamPhone", 58885544);
House house = new House(
    new Hallway("Hallway", 7),
    new Bathroom("Bathroom", 12, new Appliances("digital mirror"), new Appliances("toothbrush")),
    new LivingRoom("Living room", 50, new Appliances("Television")),
    new Kitchen("Kitchen", 30, new Appliances("Coffe maker"))
    );
mobile.OpenHouseSystem(house);
