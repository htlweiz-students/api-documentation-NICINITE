using AverageCalculator; 
namespace AverageCalculator_Test;


public class UnitTest1
{
    [Fact]
    public void add_only_one_number()
    {
        double[] test_element = new double[3];
        double[] expected_element = {1, 2, 3}; 
        Calculator list1 = new(test_element);
        Calculator list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        Assert.Equal(exception, test_element);
    }

    [Fact]
    public void add_ovveride_only_one_number()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {4, 5, 6}; 
        Calculator list1 = new(test_element);
        Calculator list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(4);
        list1.Add(5);
        list1.Add(6);

        Assert.Equal(exception, test_element);
    }

    [Fact]
    public void add_only_one_number_to_ArrayLength_is_zero()
    {
      
    }

    [Fact]
    public void add_an_array()
    {
        double[] test_element = new double[3];
        double[] expected_element = {1, 2, 3}; 
        Calculator list1 = new(test_element);
        Calculator list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(expected_element);
        Assert.Equal(exception, test_list);
    }

    [Fact]
     public void add_override_an_array()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {4, 5, 6}; 
        Calculator list1 = new(test_element);
        Calculator list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(expected_element);
        Assert.Equal(exception, test_list);
    }
}