// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x1 = true; bool y1 = true;
bool x2 = true; bool y2 = false;
bool x3 = false; bool y3 = true;
bool x4 = false; bool y4 = false;

bool LogicFuction(bool x, bool y)
{
    bool result = (!(x & y) == (!x | !y));
    return result;
}

bool a1 = LogicFuction(x1, y1);
bool a2 = LogicFuction(x2, y2);
bool a3 = LogicFuction(x3, y3);
bool a4 = LogicFuction(x4, y4);
if (a1 == a2 == a3 == a4 == true) Console.WriteLine("Выражение истинно");


