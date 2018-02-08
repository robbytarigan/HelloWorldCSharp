using System;
using Xunit;

namespace Span
{
    public class UnitTest1
    {
        [Fact]
        public void CreateASpanFromArray()
        {
		var arr = new byte[10];
		Span<byte> bytes = arr; // Implicit cast from T[] to Span<T>
        }

	[Fact]
	public void Represent_just_a_subset_of_array() {
		var arr = new byte[10];
		Span<byte> bytes = arr; // Implicit cast from T[] to Span<T>

		Span<byte> slicedBytes = bytes.Slice(start: 5, length: 2);
		slicedBytes[0] = 42;
		slicedBytes[1] = 43;
		Assert.Equal(42, slicedBytes[0]);
		Assert.Equal(43, slicedBytes[1]);
		Assert.Equal(arr[5], slicedBytes[0]);
		Assert.Equal(arr[6], slicedBytes[1]);
		// slicedBytes[2] = 44; // Throws IndexOutOfRangeException
		bytes[2] = 45; // OK
		Assert.Equal(arr[2], bytes[2]);
		Assert.Equal(45, arr[2]);
	}

	[Fact]
	public void Refer_data_on_the_stack() {
		Span<byte> bytes = stackalloc byte[2]; 	// Using C# 7.2 stackalloc support for spans
		bytes[0] = 42;
		bytes[1] = 43;
		Assert.Equal(42, bytes[0]);
		Assert.Equal(43, bytes[1]);
		// bytes[2] = 44; // Throws indexOutOfRangeException
	}
    }
}
