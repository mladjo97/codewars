// Link to kata: https://www.codewars.com/kata/expanding-dependency-chains

using System;
using System.Collections.Generic;

public class Kata 
{
  public static Dictionary<string, string[]> ExpandDependencies(Dictionary<string, string[]> dependencies) 
  {
    Dictionary<string, string[]> expandedDependencies = new Dictionary<string, string[]>();
    
    HashSet<string> referencedDependencies = new HashSet<string>();
    foreach(KeyValuePair<string, string[]> file in dependencies) 
    {
      if(referencedDependencies.Count > 0)
        referencedDependencies.Clear();
       
      referencedDependencies.UnionWith(file.Value);

      foreach(KeyValuePair<string, string[]> dependency in dependencies)
      {
        if(dependency.Key == file.Key)
          continue;
        
        HashSet<string> newRefDep = new HashSet<string>();
        
        foreach(string fileDependency in referencedDependencies)
          if(referencedDependencies.Contains(fileDependency))
            foreach(string refDependency in dependencies[fileDependency])
              newRefDep.Add(refDependency);
        
        referencedDependencies.UnionWith(newRefDep);
      }
      
      if(referencedDependencies.Contains(file.Key))
        throw new InvalidOperationException();
    
      if(!expandedDependencies.ContainsKey(file.Key))
      {
        string[] referencedDependenciesArray = new string[referencedDependencies.Count];
        referencedDependencies.CopyTo(referencedDependenciesArray);
        expandedDependencies.Add(file.Key, referencedDependenciesArray);
      }
    }
    
    return expandedDependencies;
  }
}