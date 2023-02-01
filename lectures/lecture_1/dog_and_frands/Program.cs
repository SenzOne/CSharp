int count = 0,
    distance = 10000,
    first_frend_speed = 1,
    second_frend_speed = 2,
    dog_speed = 5,
    frend = 2,
    time = 0;

while (distance > 10)
{
    if (frend == 1)
    {
        time = distance / (first_frend_speed + dog_speed);
        frend = 2;
        Console.WriteLine($"{count} От 1 >>> к 2 Distance: {distance}");
    }
    else
    {
        time = distance / (second_frend_speed + dog_speed);
        frend = 1;
        Console.WriteLine($"{count} От 2 >>> к 1 Distance: {distance}");
    }
    distance = distance - (first_frend_speed + second_frend_speed) * time;
    count++;
}
Console.WriteLine($"Count: {count}");