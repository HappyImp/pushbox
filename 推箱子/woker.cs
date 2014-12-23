using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 推箱子
{
    class woker
    {
        public bool IsWin(Status[,] s ) {
            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1); j++)
                    if (s[i, j] == Status.Destination || s[i, j] == Status.WorkerInDestination)
                        return false;
            return true;
        }
        public bool WorkMove(Status[,] s, ref int x, ref int y, int dx, int dy)
        {
            if (s[x + dx, y + dy] == Status.Passageway)
            {
                if (s[x, y] == Status.WorkerInDestination)
                {
                    s[x, y] = Status.Destination;
                    x += dx;
                    y += dy;
                    s[x, y] = Status.Worker;
                }
                else
                {
                    s[x, y] = Status.Passageway;
                    x += dx;
                    y += dy;
                    s[x, y] = Status.Worker;
                }
                return true;
            }
            else if (s[x + dx, y + dy] == Status.Destination)
            {
                if (s[x, y] == Status.WorkerInDestination)
                {
                    s[x, y] = Status.Destination;
                    x += dx;
                    y += dy;
                    s[x, y] = Status.WorkerInDestination;
                }
                else
                {
                    s[x, y] = Status.Passageway;
                    x += dx;
                    y += dy;
                    s[x, y] = Status.WorkerInDestination;
                }
                return true;
            }
            else if (s[x + dx, y + dy] == Status.Box)
            {
                int dx2 = dx * 2;
                int dy2 = dy * 2;
                if (s[x + dx2, y + dy2] == Status.Destination)
                {
                    s[x + dx2, y + dy2] = Status.BoxInDestination;
                    s[x + dx, y + dy] = Status.Worker;
                    if (s[x, y] == Status.WorkerInDestination)
                    {
                        s[x, y] = Status.Destination;
                    }
                    else { s[x, y] = Status.Passageway; }
                    x += dx;
                    y += dy;
                    return true;
                }
                else if (s[x + dx2, y + dy2] ==Status.Passageway)
                {

                    s[x + dx2, y + dy2] = Status.Box;
                    s[x + dx, y + dy] = Status.Worker;
                    if (s[x, y] == Status.WorkerInDestination)
                    {
                        s[x, y] = Status.Destination;
                    }
                    else { s[x, y] = Status.Passageway; }
                    x += dx;
                    y += dy;
                    return true;
                }
                return false;
            }
            else if (s[x + dx, y + dy] == Status.BoxInDestination)
            {
                int dx2 = dx * 2;
                int dy2 = dy * 2;
                if (s[x + dx2, y + dy2] == Status.Destination)
                {
                    s[x + dx2, y + dy2] = Status.BoxInDestination;
                    s[x + dx, y + dy] = Status.WorkerInDestination;
                    if (s[x, y] == Status.WorkerInDestination)
                    {
                        s[x, y] = Status.Destination;
                    }
                    else{ s[x, y] = Status.Passageway; }
                    x += dx;
                    y += dy;
                    return true;
                }
                else if (s[x + dx2, y + dy2] == Status.Passageway)
                {
                    s[x + dx2, y + dy2] = Status.Box;
                    s[x + dx, y + dy] = Status.WorkerInDestination;
                    if (s[x, y] == Status.Worker)
                    {
                        s[x, y] = Status.Passageway;
                        return true;
                    }
                    else { s[x, y] = Status.Destination; }
                    x += dx;
                    y += dy;
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
