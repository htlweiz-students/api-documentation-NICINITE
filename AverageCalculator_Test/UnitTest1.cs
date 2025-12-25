using AverageCalculator; 
namespace AverageCalculator_Test;


public class UnitTest1
{
    [Fact]
    public void GetElements_works()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {1, 2, 3}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        Assert.Equal(exception, test_list);
    }

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
    public void Add_digitalpoint_numbers()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {4.123, 5.245, 6.367}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(4.123);
        list1.Add(5.245);
        list1.Add(6.367);

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

    [Fact]
    public void add_digititalpoint_array()
    {
        double[] test_element = {1, 2, 3};
        double[] expected_element = {7.21, 8.43, 9.65}; 
        Average list1 = new(test_element);
        Average list2 = new(expected_element);
        double[] test_list = list1.GetElements();
        double[] exception = list2.GetElements();

        list1.Add(test_element);
        list1.Add(expected_element);
        Assert.Equal(exception, test_list);
    }

    [Fact]
    public void GetAverage_works_with_single_add()
    {
        double[] test_element = new double[3];
        Average list1 = new(test_element);
        double expection = 2;

        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        double test_list = Math.Round(list1.GetAverage(), 4);
        Assert.Equal(expection, test_list);
    }

    [Fact]
    public void GetAverage_works_with_array_add()
    {
        double[] test_element = new double[3];
        double[] elements = {1, 2, 3};
        Average list1 = new(test_element);
        double expection = 2;

        list1.Add(elements);

        double test_list = Math.Round(list1.GetAverage(), 4);
        Assert.Equal(expection, test_list);
    }

    [Fact]
    public void GetAverage_works_with_digitalpoint_add()
    {
        double[] test_element = new double[3];
        Average list1 = new(test_element);
        double expection = 2.2;

        list1.Add(1.1);
        list1.Add(2.2);
        list1.Add(3.3);

        double test_list = Math.Round(list1.GetAverage(), 4);
        Assert.Equal(expection, test_list);
    }

    [Fact]
    public void GetAverage_works_with_digitalpoint_array_add()
    {
        double[] test_element = new double[3];
        double[] elements = {1.1, 2.2, 3.3};
        Average list1 = new(test_element);
        double expection = 2.2;

        list1.Add(elements);

        double test_list = Math.Round(list1.GetAverage(), 4);
        Assert.Equal(expection, test_list);
    }

    [Fact]
    public void Count_changes_right_with_add()
    {
        double[] test_element = new double[3];
        Average list1 = new(test_element);
        int changes = 0;
        int expection = 3;

        list1.Add(1.1);
        list1.Add(2.2);
        list1.Add(3.3);

        changes = list1.Count();
        Assert.Equal(expection, changes);
    }

    [Fact]
    public void Count_changes_right_with_array_add()
    {
        double[] test_element = new double[3];
        double[] elements = {1.1, 2.2, 3.3};
        Average list1 = new(test_element);
        int changes = 0;
        int expection = 3;

        list1.Add(elements);

        changes = list1.Count();
        Assert.Equal(expection, changes);
    }

    [Fact]
    public void Count_changes_from_two_objects()
    {
        double[] test_element = new double[3];
        double[] elements = {1.1, 2.2, 3.3};

        Average list1 = new(test_element);
        Average list2 = new(test_element);
        int changes_1 = 0;
        int expection_1 = 3;
        int changes_2 = 0;
        int expection_2 = 3;

        list1.Add(elements);
        list2.Add(elements);

        changes_1 = list1.Count();
        changes_2 = list2.Count();
        Assert.Equal(expection_1, changes_1);
        Assert.Equal(expection_2, changes_2);
    }
}