public class Car : Vehicle{ // INHERITED Vehicle base properties in this case the property Brand

        public Car(){ // Deafalt constructor with no parameters 
        // Initialize the object's own fields
        this.Make = "Toyota";
        this.Model = "Supra";
        this.Year = 1989;
    }

    public Car(string make, string model, int year){ 
        Make = make;
        Model = model;
        Year = year;
    }

    // ENCAPSULATION: We are making the var speed a private parameter to make it visible only in this class scope but externally we can access it using the public methods set and get
    private int speed;

    // SETTERS AND GETTERS accessors

    // Custom Getter
    public int GetSpeed() {
        return speed;
    }

    // Custom Setter
    public void SetSpeed(int value) {
        if (value >= 0) {
            speed = value;
        }
    }

    public int Speed // HERE WE ARE CREATING THE NEW VARIABLE "Speed" THAT WILL BE RELATED WITH THE PRIVATE ONE "speed"
    {
        // N.B. The variables are different so we can access the private variable "speed" using this public "Speed" variable 
        get { return speed; } // Basic C# get accessor
        set // Basic C# set accessor
        {
            if (value >= 0)
            {
                speed = value;
            }
        }
    }

    // WE CAN USE DIRECTLY C# DEFAULT ACCESSORS IF WE DONT NEED A PRIVATE VARIABLE AND WE DONT NEED TO IMPLEMENT THE LOGIC OF SETTING AND GETTING
    public string Make { get; set; } 
    public string Model { get; set; }
    public int Year { get; set; }

}