using AverageCalculator; 
namespace AverageCalculator_Test;


public class UnitTest1
{
    [Fact]
    public void Add_numbers()
    {
        double[] test_element = new double[3];
        double[] expected_element = {1, 2, 3}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        Assert.Equal(exception, test_element);
    }

    [Fact]
    public void Add_ovveride_numbers()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {4, 5, 6}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(4);
        list1.Add(5);
        list1.Add(6);

        Assert.Equal(exception, test_element);
    }

    [Fact]
    public void Add_numbers_memory_set_to_zero()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {7, 5, 6}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(4);
        list1.Add(5);
        list1.Add(6);
        list1.Add(7);

        Assert.Equal(exception, test_element);
    }

    [Fact]
    public void Add_an_array()
    {
        double[] test_element = new double[3];
        double[] expected_element = {1, 2, 3}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(expected_element);
        Assert.Equal(exception, test_list);
    }

    [Fact]
    public void add_override_an_array()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {7, 8, 9}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(test_element);
        list1.Add(expected_element);
        Assert.Equal(exception, test_list);
    }
}