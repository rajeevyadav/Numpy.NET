// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPy_sortingTest : BaseTestCase
    {

        [TestMethod]
        public void sortTest()
        {
            // >>> a = np.array([[1,4],[3,1]])
            // >>> np.sort(a)                # sort along the last axis
            // array([[1, 4],
            //        [1, 3]])
            // >>> np.sort(a, axis=None)     # sort the flattened array
            // array([1, 1, 3, 4])
            // >>> np.sort(a, axis=0)        # sort along the first axis
            // array([[1, 1],
            //        [3, 4]])
            // 

            var a = np.array(new[,] { { 1, 4 }, { 3, 1 } });
            var given = np.sort(a);                // sort along the last axis
            var expected =
                "array([[1, 4],\n" +
                "       [1, 3]])";
            Assert.AreEqual(expected, given.repr);
            given = np.sort(a, axis: null);     // sort the flattened array
            expected =
               "array([1, 1, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            given = np.sort(a, axis: 0);        // sort along the first axis
            expected =
               "array([[1, 1],\n" +
               "       [3, 4]])";
            Assert.AreEqual(expected, given.repr);

            // Use the order keyword to specify a field to use when sorting a
            // structured array:

            // >>> dtype = [('name', 'S10'), ('height', float), ('age', int)]
            // >>> values = [('Arthur', 1.8, 41), ('Lancelot', 1.9, 38),
            // ...           ('Galahad', 1.7, 38)]
            // >>> a = np.array(values, dtype=dtype)       # create a structured array
            // >>> np.sort(a, order='height')                        
            // array([('Galahad', 1.7, 38), ('Arthur', 1.8, 41),
            //        ('Lancelot', 1.8999999999999999, 38)],
            //       dtype=[('name', '|S10'), ('height', '<f8'), ('age', '<i4')])
            // 

#if TODO
             given=  dtype = [('name', 'S10'), ('height', float), ('age', int)];
             given=  values = [('Arthur', 1.8, 41), ('Lancelot', 1.9, 38),;
             expected=
                "...           ('Galahad', 1.7, 38)]";
            Assert.AreEqual(expected, given.repr);
             given=  a = np.array(values, dtype=dtype)       # create a structured array;
             given=  np.sort(a, order='height')                        ;
             expected=
                "array([('Galahad', 1.7, 38), ('Arthur', 1.8, 41),\n" +
                "       ('Lancelot', 1.8999999999999999, 38)],\n" +
                "      dtype=[('name', '|S10'), ('height', '<f8'), ('age', '<i4')])";
            Assert.AreEqual(expected, given.repr);
#endif
            // Sort by age, then height if ages are equal:

            // >>> np.sort(a, order=['age', 'height'])               
            // array([('Galahad', 1.7, 38), ('Lancelot', 1.8999999999999999, 38),
            //        ('Arthur', 1.8, 41)],
            //       dtype=[('name', '|S10'), ('height', '<f8'), ('age', '<i4')])
            // 

#if TODO
             given=  np.sort(a, order={'age', 'height'})               ;
             expected=
                "array([('Galahad', 1.7, 38), ('Lancelot', 1.8999999999999999, 38),\n" +
                "       ('Arthur', 1.8, 41)],\n" +
                "      dtype=[('name', '|S10'), ('height', '<f8'), ('age', '<i4')])";
            Assert.AreEqual(expected, given.repr);
#endif
        }


        [TestMethod]
        public void lexsortTest()
        {
            // Sort names: first by surname, then by name.
            
            // >>> surnames =    ('Hertz',    'Galilei', 'Hertz')
            // >>> first_names = ('Heinrich', 'Galileo', 'Gustav')
            // >>> ind = np.lexsort((first_names, surnames))
            // >>> ind
            // array([1, 2, 0])
            // 
            
            #if TODO
            var given=  surnames =    ('Hertz',    'Galilei', 'Hertz');
             given=  first_names = ('Heinrich', 'Galileo', 'Gustav');
             given=  ind = np.lexsort((first_names, surnames));
             given=  ind;
            var expected=
                "array([1, 2, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> [surnames[i] + ", " + first_names[i] for i in ind]
            // ['Galilei, Galileo', 'Hertz, Gustav', 'Hertz, Heinrich']
            // 
            
            #if TODO
             given=  [surnames[i] + ", " + first_names[i] for i in ind];
             expected=
                "['Galilei, Galileo', 'Hertz, Gustav', 'Hertz, Heinrich']";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Sort two columns of numbers:
            
            // >>> a = [1,5,1,4,3,4,4] # First column
            // >>> b = [9,4,0,4,0,2,1] # Second column
            // >>> ind = np.lexsort((b,a)) # Sort by a, then by b
            // >>> print(ind)
            // [2 0 4 6 5 3 1]
            // 
            
            #if TODO
             given=  a = [1,5,1,4,3,4,4] # First column;
             given=  b = [9,4,0,4,0,2,1] # Second column;
             given=  ind = np.lexsort((b,a)) # Sort by a, then by b;
             given=  print(ind);
             expected=
                "[2 0 4 6 5 3 1]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> [(a[i],b[i]) for i in ind]
            // [(1, 0), (1, 9), (3, 0), (4, 1), (4, 2), (4, 4), (5, 4)]
            // 
            
            #if TODO
             given=  [(a[i],b[i]) for i in ind];
             expected=
                "[(1, 0), (1, 9), (3, 0), (4, 1), (4, 2), (4, 4), (5, 4)]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Note that sorting is first according to the elements of a.
            // Secondary sorting is according to the elements of b.
            
            // A normal argsort would have yielded:
            
            // >>> [(a[i],b[i]) for i in np.argsort(a)]
            // [(1, 9), (1, 0), (3, 0), (4, 4), (4, 2), (4, 1), (5, 4)]
            // 
            
            #if TODO
             given=  {(a{i},b{i}) for i in np.argsort(a)};
             expected=
                "[(1, 9), (1, 0), (3, 0), (4, 4), (4, 2), (4, 1), (5, 4)]";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Structured arrays are sorted lexically by argsort:
            
            // >>> x = np.array([(1,9), (5,4), (1,0), (4,4), (3,0), (4,2), (4,1)],
            // ...              dtype=np.dtype([('x', int), ('y', int)]))
            // 
            
            #if TODO
             given=  x = np.array({(1,9), (5,4), (1,0), (4,4), (3,0), (4,2), (4,1)},;
             expected=
                "...              dtype=np.dtype([('x', int), ('y', int)]))";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.argsort(x) # or np.argsort(x, order=('x', 'y'))
            // array([2, 0, 4, 6, 5, 3, 1])
            // 
            
            #if TODO
             given=  np.argsort(x) # or np.argsort(x, order=('x', 'y'));
             expected=
                "array([2, 0, 4, 6, 5, 3, 1])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void argsortTest()
        {
            // One dimensional array:
            
            // >>> x = np.array([3, 1, 2])
            // >>> np.argsort(x)
            // array([1, 2, 0])
            // 
            
            #if TODO
            var given=  x = np.array({3, 1, 2});
             given=  np.argsort(x);
            var expected=
                "array([1, 2, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Two-dimensional array:
            
            // >>> x = np.array([[0, 3], [2, 2]])
            // >>> x
            // array([[0, 3],
            //        [2, 2]])
            // 
            
            #if TODO
             given=  x = np.array({{0, 3}, {2, 2}});
             given=  x;
             expected=
                "array([[0, 3],\n" +
                "       [2, 2]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.argsort(x, axis=0)  # sorts along first axis (down)
            // array([[0, 1],
            //        [1, 0]])
            // 
            
            #if TODO
             given=  np.argsort(x, axis=0)  # sorts along first axis (down);
             expected=
                "array([[0, 1],\n" +
                "       [1, 0]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.argsort(x, axis=1)  # sorts along last axis (across)
            // array([[0, 1],
            //        [0, 1]])
            // 
            
            #if TODO
             given=  np.argsort(x, axis=1)  # sorts along last axis (across);
             expected=
                "array([[0, 1],\n" +
                "       [0, 1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Indices of the sorted elements of a N-dimensional array:
            
            // >>> ind = np.unravel_index(np.argsort(x, axis=None), x.shape)
            // >>> ind
            // (array([0, 1, 1, 0]), array([0, 0, 1, 1]))
            // >>> x[ind]  # same as np.sort(x, axis=None)
            // array([0, 2, 2, 3])
            // 
            
            #if TODO
             given=  ind = np.unravel_index(np.argsort(x, axis=None), x.shape);
             given=  ind;
             expected=
                "(array([0, 1, 1, 0]), array([0, 0, 1, 1]))";
            Assert.AreEqual(expected, given.repr);
             given=  x{ind}  # same as np.sort(x, axis=None);
             expected=
                "array([0, 2, 2, 3])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Sorting with keys:
            
            // >>> x = np.array([(1, 0), (0, 1)], dtype=[('x', '<i4'), ('y', '<i4')])
            // >>> x
            // array([(1, 0), (0, 1)],
            //       dtype=[('x', '<i4'), ('y', '<i4')])
            // 
            
            #if TODO
             given=  x = np.array({(1, 0), (0, 1)}, dtype={('x', '<i4'), ('y', '<i4')});
             given=  x;
             expected=
                "array([(1, 0), (0, 1)],\n" +
                "      dtype=[('x', '<i4'), ('y', '<i4')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.argsort(x, order=('x','y'))
            // array([1, 0])
            // 
            
            #if TODO
             given=  np.argsort(x, order=('x','y'));
             expected=
                "array([1, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.argsort(x, order=('y','x'))
            // array([0, 1])
            // 
            
            #if TODO
             given=  np.argsort(x, order=('y','x'));
             expected=
                "array([0, 1])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void sort_complexTest()
        {
            // >>> np.sort_complex([5, 3, 6, 2, 1])
            // array([ 1.+0.j,  2.+0.j,  3.+0.j,  5.+0.j,  6.+0.j])
            // 
            
            #if TODO
            var given=  np.sort_complex({5, 3, 6, 2, 1});
            var expected=
                "array([ 1.+0.j,  2.+0.j,  3.+0.j,  5.+0.j,  6.+0.j])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.sort_complex([1 + 2j, 2 - 1j, 3 - 2j, 3 - 3j, 3 + 5j])
            // array([ 1.+2.j,  2.-1.j,  3.-3.j,  3.-2.j,  3.+5.j])
            // 
            
            #if TODO
             given=  np.sort_complex({1 + 2j, 2 - 1j, 3 - 2j, 3 - 3j, 3 + 5j});
             expected=
                "array([ 1.+2.j,  2.-1.j,  3.-3.j,  3.-2.j,  3.+5.j])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void partitionTest()
        {
            // >>> a = np.array([3, 4, 2, 1])
            // >>> np.partition(a, 3)
            // array([2, 1, 3, 4])
            // 
            
            #if TODO
            var given=  a = np.array({3, 4, 2, 1});
             given=  np.partition(a, 3);
            var expected=
                "array([2, 1, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.partition(a, (1, 3))
            // array([1, 2, 3, 4])
            // 
            
            #if TODO
             given=  np.partition(a, (1, 3));
             expected=
                "array([1, 2, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void argpartitionTest()
        {
            // One dimensional array:
            
            // >>> x = np.array([3, 4, 2, 1])
            // >>> x[np.argpartition(x, 3)]
            // array([2, 1, 3, 4])
            // >>> x[np.argpartition(x, (1, 3))]
            // array([1, 2, 3, 4])
            // 
            
            #if TODO
            var given=  x = np.array({3, 4, 2, 1});
             given=  x{np.argpartition(x, 3)};
            var expected=
                "array([2, 1, 3, 4])";
            Assert.AreEqual(expected, given.repr);
             given=  x{np.argpartition(x, (1, 3))};
             expected=
                "array([1, 2, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x = [3, 4, 2, 1]
            // >>> np.array(x)[np.argpartition(x, 3)]
            // array([2, 1, 3, 4])
            // 
            
            #if TODO
             given=  x = [3, 4, 2, 1];
             given=  np.array(x){np.argpartition(x, 3)};
             expected=
                "array([2, 1, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void argmaxTest()
        {
            // >>> a = np.arange(6).reshape(2,3) + 10
            // >>> a
            // array([[10, 11, 12],
            //        [13, 14, 15]])
            // >>> np.argmax(a)
            // 5
            // >>> np.argmax(a, axis=0)
            // array([1, 1, 1])
            // >>> np.argmax(a, axis=1)
            // array([2, 2])
            // 
            
            #if TODO
            var given=  a = np.arange(6).reshape(2,3) + 10;
             given=  a;
            var expected=
                "array([[10, 11, 12],\n" +
                "       [13, 14, 15]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmax(a);
             expected=
                "5";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmax(a, axis=0);
             expected=
                "array([1, 1, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmax(a, axis=1);
             expected=
                "array([2, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Indexes of the maximal elements of a N-dimensional array:
            
            // >>> ind = np.unravel_index(np.argmax(a, axis=None), a.shape)
            // >>> ind
            // (1, 2)
            // >>> a[ind]
            // 15
            // 
            
            #if TODO
             given=  ind = np.unravel_index(np.argmax(a, axis=None), a.shape);
             given=  ind;
             expected=
                "(1, 2)";
            Assert.AreEqual(expected, given.repr);
             given=  a[ind];
             expected=
                "15";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> b = np.arange(6)
            // >>> b[1] = 5
            // >>> b
            // array([0, 5, 2, 3, 4, 5])
            // >>> np.argmax(b)  # Only the first occurrence is returned.
            // 1
            // 
            
            #if TODO
             given=  b = np.arange(6);
             given=  b[1] = 5;
             given=  b;
             expected=
                "array([0, 5, 2, 3, 4, 5])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmax(b)  # Only the first occurrence is returned.;
             expected=
                "1";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void nanargmaxTest()
        {
            // >>> a = np.array([[np.nan, 4], [2, 3]])
            // >>> np.argmax(a)
            // 0
            // >>> np.nanargmax(a)
            // 1
            // >>> np.nanargmax(a, axis=0)
            // array([1, 0])
            // >>> np.nanargmax(a, axis=1)
            // array([1, 1])
            // 
            
            #if TODO
            var given=  a = np.array({{np.nan, 4}, {2, 3}});
             given=  np.argmax(a);
            var expected=
                "0";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmax(a);
             expected=
                "1";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmax(a, axis=0);
             expected=
                "array([1, 0])";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmax(a, axis=1);
             expected=
                "array([1, 1])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void argminTest()
        {
            // >>> a = np.arange(6).reshape(2,3) + 10
            // >>> a
            // array([[10, 11, 12],
            //        [13, 14, 15]])
            // >>> np.argmin(a)
            // 0
            // >>> np.argmin(a, axis=0)
            // array([0, 0, 0])
            // >>> np.argmin(a, axis=1)
            // array([0, 0])
            // 
            
            #if TODO
            var given=  a = np.arange(6).reshape(2,3) + 10;
             given=  a;
            var expected=
                "array([[10, 11, 12],\n" +
                "       [13, 14, 15]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmin(a);
             expected=
                "0";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmin(a, axis=0);
             expected=
                "array([0, 0, 0])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmin(a, axis=1);
             expected=
                "array([0, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Indices of the minimum elements of a N-dimensional array:
            
            // >>> ind = np.unravel_index(np.argmin(a, axis=None), a.shape)
            // >>> ind
            // (0, 0)
            // >>> a[ind]
            // 10
            // 
            
            #if TODO
             given=  ind = np.unravel_index(np.argmin(a, axis=None), a.shape);
             given=  ind;
             expected=
                "(0, 0)";
            Assert.AreEqual(expected, given.repr);
             given=  a[ind];
             expected=
                "10";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> b = np.arange(6) + 10
            // >>> b[4] = 10
            // >>> b
            // array([10, 11, 12, 13, 10, 15])
            // >>> np.argmin(b)  # Only the first occurrence is returned.
            // 0
            // 
            
            #if TODO
             given=  b = np.arange(6) + 10;
             given=  b[4] = 10;
             given=  b;
             expected=
                "array([10, 11, 12, 13, 10, 15])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argmin(b)  # Only the first occurrence is returned.;
             expected=
                "0";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void nanargminTest()
        {
            // >>> a = np.array([[np.nan, 4], [2, 3]])
            // >>> np.argmin(a)
            // 0
            // >>> np.nanargmin(a)
            // 2
            // >>> np.nanargmin(a, axis=0)
            // array([1, 1])
            // >>> np.nanargmin(a, axis=1)
            // array([1, 0])
            // 
            
            #if TODO
            var given=  a = np.array({{np.nan, 4}, {2, 3}});
             given=  np.argmin(a);
            var expected=
                "0";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmin(a);
             expected=
                "2";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmin(a, axis=0);
             expected=
                "array([1, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  np.nanargmin(a, axis=1);
             expected=
                "array([1, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void argwhereTest()
        {
            // >>> x = np.arange(6).reshape(2,3)
            // >>> x
            // array([[0, 1, 2],
            //        [3, 4, 5]])
            // >>> np.argwhere(x>1)
            // array([[0, 2],
            //        [1, 0],
            //        [1, 1],
            //        [1, 2]])
            // 
            
            #if TODO
            var given=  x = np.arange(6).reshape(2,3);
             given=  x;
            var expected=
                "array([[0, 1, 2],\n" +
                "       [3, 4, 5]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.argwhere(x>1);
             expected=
                "array([[0, 2],\n" +
                "       [1, 0],\n" +
                "       [1, 1],\n" +
                "       [1, 2]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void nonzeroTest()
        {
            // >>> x = np.array([[3, 0, 0], [0, 4, 0], [5, 6, 0]])
            // >>> x
            // array([[3, 0, 0],
            //        [0, 4, 0],
            //        [5, 6, 0]])
            // >>> np.nonzero(x)
            // (array([0, 1, 2, 2]), array([0, 1, 0, 1]))
            // 
            
            #if TODO
            var given=  x = np.array({{3, 0, 0}, {0, 4, 0}, {5, 6, 0}});
             given=  x;
            var expected=
                "array([[3, 0, 0],\n" +
                "       [0, 4, 0],\n" +
                "       [5, 6, 0]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.nonzero(x);
             expected=
                "(array([0, 1, 2, 2]), array([0, 1, 0, 1]))";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x[np.nonzero(x)]
            // array([3, 4, 5, 6])
            // >>> np.transpose(np.nonzero(x))
            // array([[0, 0],
            //        [1, 1],
            //        [2, 0],
            //        [2, 1])
            // 
            
            #if TODO
             given=  x{np.nonzero(x)};
             expected=
                "array([3, 4, 5, 6])";
            Assert.AreEqual(expected, given.repr);
             given=  np.transpose(np.nonzero(x));
             expected=
                "array([[0, 0],\n" +
                "       [1, 1],\n" +
                "       [2, 0],\n" +
                "       [2, 1])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // A common use for nonzero is to find the indices of an array, where
            // a condition is True.  Given an array a, the condition a > 3 is a
            // boolean array and since False is interpreted as 0, np.nonzero(a > 3)
            // yields the indices of the a where the condition is true.
            
            // >>> a = np.array([[1, 2, 3], [4, 5, 6], [7, 8, 9]])
            // >>> a > 3
            // array([[False, False, False],
            //        [ True,  True,  True],
            //        [ True,  True,  True]])
            // >>> np.nonzero(a > 3)
            // (array([1, 1, 1, 2, 2, 2]), array([0, 1, 2, 0, 1, 2]))
            // 
            
            #if TODO
             given=  a = np.array({{1, 2, 3}, {4, 5, 6}, {7, 8, 9}});
             given=  a > 3;
             expected=
                "array([[False, False, False],\n" +
                "       [ True,  True,  True],\n" +
                "       [ True,  True,  True]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.nonzero(a > 3);
             expected=
                "(array([1, 1, 1, 2, 2, 2]), array([0, 1, 2, 0, 1, 2]))";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using this result to index a is equivalent to using the mask directly:
            
            // >>> a[np.nonzero(a > 3)]
            // array([4, 5, 6, 7, 8, 9])
            // >>> a[a > 3]  # prefer this spelling
            // array([4, 5, 6, 7, 8, 9])
            // 
            
            #if TODO
             given=  a{np.nonzero(a > 3)};
             expected=
                "array([4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
             given=  a[a > 3]  # prefer this spelling;
             expected=
                "array([4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // nonzero can also be called as a method of the array.
            
            // >>> (a > 3).nonzero()
            // (array([1, 1, 1, 2, 2, 2]), array([0, 1, 2, 0, 1, 2]))
            // 
            
            #if TODO
             given=  (a > 3).nonzero();
             expected=
                "(array([1, 1, 1, 2, 2, 2]), array([0, 1, 2, 0, 1, 2]))";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void flatnonzeroTest()
        {
            // >>> x = np.arange(-2, 3)
            // >>> x
            // array([-2, -1,  0,  1,  2])
            // >>> np.flatnonzero(x)
            // array([0, 1, 3, 4])
            // 
            
            #if TODO
            var given=  x = np.arange(-2, 3);
             given=  x;
            var expected=
                "array([-2, -1,  0,  1,  2])";
            Assert.AreEqual(expected, given.repr);
             given=  np.flatnonzero(x);
             expected=
                "array([0, 1, 3, 4])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Use the indices of the non-zero elements as an index array to extract
            // these elements:
            
            // >>> x.ravel()[np.flatnonzero(x)]
            // array([-2, -1,  1,  2])
            // 
            
            #if TODO
             given=  x.ravel(){np.flatnonzero(x)};
             expected=
                "array([-2, -1,  1,  2])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void whereTest()
        {
            // >>> a = np.arange(10)
            // >>> a
            // array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])
            // >>> np.where(a < 5, a, 10*a)
            // array([ 0,  1,  2,  3,  4, 50, 60, 70, 80, 90])
            // 
            
            #if TODO
            var given=  a = np.arange(10);
             given=  a;
            var expected=
                "array([0, 1, 2, 3, 4, 5, 6, 7, 8, 9])";
            Assert.AreEqual(expected, given.repr);
             given=  np.where(a < 5, a, 10*a);
             expected=
                "array([ 0,  1,  2,  3,  4, 50, 60, 70, 80, 90])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // This can be used on multidimensional arrays too:
            
            // >>> np.where([[True, False], [True, True]],
            // ...          [[1, 2], [3, 4]],
            // ...          [[9, 8], [7, 6]])
            // array([[1, 8],
            //        [3, 4]])
            // 
            
            #if TODO
             given=  np.where({{True, False}, {True, True}},;
             expected=
                "...          [[1, 2], [3, 4]],\n" +
                "...          [[9, 8], [7, 6]])\n" +
                "array([[1, 8],\n" +
                "       [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // The shapes of x, y, and the condition are broadcast together:
            
            // >>> x, y = np.ogrid[:3, :4]
            // >>> np.where(x < y, x, 10 + y)  # both x and 10+y are broadcast
            // array([[10,  0,  0,  0],
            //        [10, 11,  1,  1],
            //        [10, 11, 12,  2]])
            // 
            
            #if TODO
             given=  x, y = np.ogrid{:3, :4};
             given=  np.where(x < y, x, 10 + y)  # both x and 10+y are broadcast;
             expected=
                "array([[10,  0,  0,  0],\n" +
                "       [10, 11,  1,  1],\n" +
                "       [10, 11, 12,  2]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> a = np.array([[0, 1, 2],
            // ...               [0, 2, 4],
            // ...               [0, 3, 6]])
            // >>> np.where(a < 4, a, -1)  # -1 is broadcast
            // array([[ 0,  1,  2],
            //        [ 0,  2, -1],
            //        [ 0,  3, -1]])
            // 
            
            #if TODO
             given=  a = np.array({{0, 1, 2},;
             expected=
                "...               [0, 2, 4],\n" +
                "...               [0, 3, 6]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.where(a < 4, a, -1)  # -1 is broadcast;
             expected=
                "array([[ 0,  1,  2],\n" +
                "       [ 0,  2, -1],\n" +
                "       [ 0,  3, -1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void searchsortedTest()
        {
            // >>> np.searchsorted([1,2,3,4,5], 3)
            // 2
            // >>> np.searchsorted([1,2,3,4,5], 3, side='right')
            // 3
            // >>> np.searchsorted([1,2,3,4,5], [-10, 10, 2, 3])
            // array([0, 5, 1, 2])
            // 
            
            #if TODO
            var given=  np.searchsorted({1,2,3,4,5}, 3);
            var expected=
                "2";
            Assert.AreEqual(expected, given.repr);
             given=  np.searchsorted({1,2,3,4,5}, 3, side='right');
             expected=
                "3";
            Assert.AreEqual(expected, given.repr);
             given=  np.searchsorted({1,2,3,4,5}, {-10, 10, 2, 3});
             expected=
                "array([0, 5, 1, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void extractTest()
        {
            // >>> arr = np.arange(12).reshape((3, 4))
            // >>> arr
            // array([[ 0,  1,  2,  3],
            //        [ 4,  5,  6,  7],
            //        [ 8,  9, 10, 11]])
            // >>> condition = np.mod(arr, 3)==0
            // >>> condition
            // array([[ True, False, False,  True],
            //        [False, False,  True, False],
            //        [False,  True, False, False]])
            // >>> np.extract(condition, arr)
            // array([0, 3, 6, 9])
            // 
            
            #if TODO
            var given=  arr = np.arange(12).reshape((3, 4));
             given=  arr;
            var expected=
                "array([[ 0,  1,  2,  3],\n" +
                "       [ 4,  5,  6,  7],\n" +
                "       [ 8,  9, 10, 11]])";
            Assert.AreEqual(expected, given.repr);
             given=  condition = np.mod(arr, 3)==0;
             given=  condition;
             expected=
                "array([[ True, False, False,  True],\n" +
                "       [False, False,  True, False],\n" +
                "       [False,  True, False, False]])";
            Assert.AreEqual(expected, given.repr);
             given=  np.extract(condition, arr);
             expected=
                "array([0, 3, 6, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // If condition is boolean:
            
            // >>> arr[condition]
            // array([0, 3, 6, 9])
            // 
            
            #if TODO
             given=  arr[condition];
             expected=
                "array([0, 3, 6, 9])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void count_nonzeroTest()
        {
            // >>> np.count_nonzero(np.eye(4))
            // 4
            // >>> np.count_nonzero([[0,1,7,0,0],[3,0,0,2,19]])
            // 5
            // >>> np.count_nonzero([[0,1,7,0,0],[3,0,0,2,19]], axis=0)
            // array([1, 1, 1, 1, 1])
            // >>> np.count_nonzero([[0,1,7,0,0],[3,0,0,2,19]], axis=1)
            // array([2, 3])
            // 
            
            #if TODO
            var given=  np.count_nonzero(np.eye(4));
            var expected=
                "4";
            Assert.AreEqual(expected, given.repr);
             given=  np.count_nonzero({{0,1,7,0,0},{3,0,0,2,19}});
             expected=
                "5";
            Assert.AreEqual(expected, given.repr);
             given=  np.count_nonzero({{0,1,7,0,0},{3,0,0,2,19}}, axis=0);
             expected=
                "array([1, 1, 1, 1, 1])";
            Assert.AreEqual(expected, given.repr);
             given=  np.count_nonzero({{0,1,7,0,0},{3,0,0,2,19}}, axis=1);
             expected=
                "array([2, 3])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
    }
}