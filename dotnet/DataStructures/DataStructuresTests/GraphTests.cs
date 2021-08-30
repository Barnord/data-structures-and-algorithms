using System;
using System.Collections.Generic;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class GraphTests
  {
    [Fact]
    public void AAddNode()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);

      Assert.Equal(4, node.Value);
    }

    [Fact]
    public void BAddEdge()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);
      Vertex<int> noode = graph.AddNode(5);

      graph.AddEdge(node, noode, 6);

      var values = graph.AdjacencyLists.Values;

      Assert.NotNull(values);
    }

    [Fact]
    public void CGetNodes()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);
      Vertex<int> noode = graph.AddNode(5);

      List<Vertex<int>> values = new();
      values.Add(node);
      values.Add(noode);


      Assert.Equal(values, graph.GetNodes());
    }

    [Fact]
    public void DGetNeighbors()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);
      Vertex<int> noode = graph.AddNode(5);

      graph.AddEdge(node, noode, 6);

      List<Vertex<int>> values = new();
      values.Add(node);

      Assert.Equal(values, graph.GetNeighbors(noode));
    }

    [Fact]
    public void EGetNeighborsWithWeight()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);
      Vertex<int> noode = graph.AddNode(5);

      graph.AddEdge(node, noode, 6);

      List<string> values = new();
      values.Add("4: 6");

      Assert.Equal(values, graph.GetHeavyNeighbors(noode));
    }

    [Fact]
    public void FGetSize()
    {
      Graph<int> graph = new();

      graph.AddNode(4);
      graph.AddNode(5);

      Assert.Equal(2, graph.GetSize());
    }

    [Fact]
    public void GSingleNodeAndEdgeGraph()
    {
      Graph<int> graph = new();

      Vertex<int> node = graph.AddNode(4);
      Vertex<int> noode = graph.AddNode(5);

      graph.AddEdge(node, noode, 6);

      Assert.Equal();
    }

    [Fact]
    public void HEmptyGraph()
    {

    }
  }
}
