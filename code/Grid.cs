using Sandbox;


public class Grid : Entity
{

    /*
        w = wall
        e = empty
        b = box
        h = hard box
        x = explosive
        s = spawn
    */
    char[,] gridArry = new char[32,32];
    int x=0;
    int y=0;
    Vector3 gridPos;
    //grid sets
    public void SetWall(int x, int y)
    {
        if(gridArry[x,y]=='e')
            gridArry[x,y] = 'w';
    }
    public void SetEmpty(int x , int y)
    {
        gridArry[x,y]='e';
    }
    public void SetBox(int x, int y)
    {
        if(gridArry[x,y]=='e')
            gridArry[x,y]='b';
    }
    public void SetHard(int x, int y)
    {
        if(gridArry[x,y]=='e')
            gridArry[x,y]='h';
    }
    public void SetExplosive(int x, int y)
    {
        if(gridArry[x,y]=='e')
            gridArry[x,y]='x';
    }
    public void SetSpawn(int x, int y)
    {
        if(gridArry[x,y]=='e')
            gridArry[x,y]='s';
    }

//grid checks
    public bool IsWall(int x, int y)
    {
        if(gridArry[x,y]!='w')
            return false;
        return true;
    }
    public bool IsEmpty(int x, int y)
    {
        if(gridArry[x,y]!='e')
            return false;
        return true;
    }
    public bool IsBox(int x, int y)
    {
        if(gridArry[x,y]!='b')
            return false;
        return true;
    }
    public bool IsHard(int x, int y)
    {
        if(gridArry[x,y]!='h')
            return false;
        return true;
    }
    public bool IsExplosive(int x, int y)
    {
        if(gridArry[x,y]!='x')
            return false;
        return true;
    }
    public bool IsSapwn(int x, int y)
    {
        if(gridArry[x,y]!='s')
            return false;
        return true;
    }

    public void InitGrid()
    {
        for(x=0;x<32;x++){
            for(y=0;y<32;y++){
                gridArry[x,y]='e';
            }
        }
    }
    public Vector3 getPos(int x, int y)
    {
        x++;
        y++;
        gridPos.x = x*64;
        gridPos.y = y*64;
        gridPos.z = 0;
        gridPos.x -= 1028;
        gridPos.y -= 1028;
        return gridPos;
    }

    public int getXgrid(Vector3 pos)
    {
        pos.x += 1028;
        pos.x = pos.x/64;
        int x = (int)pos.x;
        return x;
    }
    public int getYgrid(Vector3 pos)
    {
        pos.y += 1028;
        pos.y = pos.y/64;
        int y = (int)pos.y;
        return y;
    }

    public void generate()
    {
        for(x=0; x<31; x++){
            for(y=0; y<31; y++){
                if((x%2==0)&&(y%2==0)){
                    new wall().SetPosition(getPos(x,y));
                }
                else if(((x==0)||(y==0))||((x==30)||(y==30))){
                    new wall().SetPosition(getPos(x,y));
                }
            }
        }
    }


}