class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        result ={}
        
        for i in strs:
            
            # print(i)
            temp = list(i)
            temp.sort()
            temp = ''.join(temp)
            # print("temp",temp)
            if temp not in result.keys():
                result[temp] = [i]
            else:
                t = result[temp]
                # print("t",t)
                t.append(i)
                result[temp] = t
            # print("result",result)
            
        return result.values()
