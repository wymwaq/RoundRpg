-- this file is generated by program!
-- don't change it manaully.
-- source file: hero_animation
-- created at: 
-- copyright@zhouwei


local data = {}
local class_data = {}
local index_one_data = nil
class_data["data"] = data

function class_data.getDataByID(id)
    return data[id]
end




function class_data.getDataByIndexOne(modelName)

    if index_one_data == nil then
      class_data.initIndexOneData()
    end

    return index_one_data[modelName]
end

function class_data.initIndexOneData()
    index_one_data = {}
    for k,v in pairs(data) do
        if index_one_data[v.modelName] == nil then
          index_one_data[v.modelName] = {}
        end

        index_one_data[v.modelName][v.id] = v

    end
end
		
data[1] = { id = 1,  modelName = "0002_00_00",  animName = "attack",  animLength = 1.333333}
data[2] = { id = 2,  modelName = "0002_00_00",  animName = "die",  animLength = 1.0}
data[3] = { id = 3,  modelName = "0002_00_00",  animName = "hit",  animLength = 1.0}
data[4] = { id = 4,  modelName = "0002_00_00",  animName = "idle",  animLength = 1.333333}
data[5] = { id = 5,  modelName = "0002_00_00",  animName = "move",  animLength = 1.0}
data[6] = { id = 6,  modelName = "0002_00_00",  animName = "skill",  animLength = 1.666667}
data[7] = { id = 7,  modelName = "0006_02_00",  animName = "attack",  animLength = 1.166667}
data[8] = { id = 8,  modelName = "0006_02_00",  animName = "die",  animLength = 1.666667}
data[9] = { id = 9,  modelName = "0006_02_00",  animName = "hit",  animLength = 0.8333335}
data[10] = { id = 10,  modelName = "0006_02_00",  animName = "idle",  animLength = 1.333333}
data[11] = { id = 11,  modelName = "0006_02_00",  animName = "move",  animLength = 0.6666667}
data[12] = { id = 12,  modelName = "0006_02_00",  animName = "skill",  animLength = 2.166667}
data[13] = { id = 13,  modelName = "0009_00_00",  animName = "attack",  animLength = 1.333333}
data[14] = { id = 14,  modelName = "0009_00_00",  animName = "die",  animLength = 1.5}
data[15] = { id = 15,  modelName = "0009_00_00",  animName = "hit",  animLength = 0.8333335}
data[16] = { id = 16,  modelName = "0009_00_00",  animName = "idle",  animLength = 1.333333}
data[17] = { id = 17,  modelName = "0009_00_00",  animName = "move",  animLength = 0.8333335}
data[18] = { id = 18,  modelName = "0009_00_00",  animName = "skill",  animLength = 1.666667}
data[19] = { id = 19,  modelName = "0025_00_00",  animName = "attack",  animLength = 1.0}
data[20] = { id = 20,  modelName = "0025_00_00",  animName = "die",  animLength = 1.0}
data[21] = { id = 21,  modelName = "0025_00_00",  animName = "hit",  animLength = 0.8333335}
data[22] = { id = 22,  modelName = "0025_00_00",  animName = "idle",  animLength = 1.0}
data[23] = { id = 23,  modelName = "0025_00_00",  animName = "move",  animLength = 0.6666667}
data[24] = { id = 24,  modelName = "0025_00_00",  animName = "skill",  animLength = 1.333334}
data[25] = { id = 25,  modelName = "0082_00_00",  animName = "attack",  animLength = 1.166667}
data[26] = { id = 26,  modelName = "0082_00_00",  animName = "die",  animLength = 1.166667}
data[27] = { id = 27,  modelName = "0082_00_00",  animName = "hit",  animLength = 1.333334}
data[28] = { id = 28,  modelName = "0082_00_00",  animName = "idle",  animLength = 1.333333}
data[29] = { id = 29,  modelName = "0082_00_00",  animName = "move",  animLength = 0.8333335}
data[30] = { id = 30,  modelName = "0082_00_00",  animName = "skill",  animLength = 1.666667}
data[31] = { id = 31,  modelName = "0445_00_00",  animName = "attack",  animLength = 1.333333}
data[32] = { id = 32,  modelName = "0445_00_00",  animName = "die",  animLength = 1.333334}
data[33] = { id = 33,  modelName = "0445_00_00",  animName = "hit",  animLength = 1.0}
data[34] = { id = 34,  modelName = "0445_00_00",  animName = "idle",  animLength = 1.333333}
data[35] = { id = 35,  modelName = "0445_00_00",  animName = "move",  animLength = 1.0}
data[36] = { id = 36,  modelName = "0445_00_00",  animName = "skill",  animLength = 1.5}
data[37] = { id = 37,  modelName = "0716_00_00",  animName = "attack",  animLength = 1.166667}
data[38] = { id = 38,  modelName = "0716_00_00",  animName = "die",  animLength = 1.5}
data[39] = { id = 39,  modelName = "0716_00_00",  animName = "hit",  animLength = 0.8333335}
data[40] = { id = 40,  modelName = "0716_00_00",  animName = "idle",  animLength = 1.333333}
data[41] = { id = 41,  modelName = "0716_00_00",  animName = "move",  animLength = 0.8333335}
data[42] = { id = 42,  modelName = "0716_00_00",  animName = "skill",  animLength = 1.333334}
data[43] = { id = 43,  modelName = "0717_00_00",  animName = "attack",  animLength = 1.333333}
data[44] = { id = 44,  modelName = "0717_00_00",  animName = "die",  animLength = 1.333333}
data[45] = { id = 45,  modelName = "0717_00_00",  animName = "hit",  animLength = 1.166667}
data[46] = { id = 46,  modelName = "0717_00_00",  animName = "idle",  animLength = 1.0}
data[47] = { id = 47,  modelName = "0717_00_00",  animName = "move",  animLength = 0.8333334}
data[48] = { id = 48,  modelName = "0717_00_00",  animName = "skill",  animLength = 1.666667}

return class_data