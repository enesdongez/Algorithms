// Dijkstra.cpp : En kýsa yol algoritmasý
// www.zafercomert.com
#include "stdafx.h"
#include "cstring"
#define N 6
#define EBAS 0x7FFFFFFF /* 32 bitlik en büyük artý sayý*/
void Dijkstra();
int GRAF[N][N] = { { -1, 7, 4, -1, 2, -1 },
{ 7, -1, 3, 2, -1, 6 }, { 4, 3, -1, 8, 1, -1 },
{ -1, 2, 8, -1, 10, 3 }, { 2, -1, 1, 10, -1, -1 },
{ -1, 6, -1, 3, -1, -1 } };
int EKM[N];
char ROTA[N][N] = { NULL };
void _tmain(int argc, _TCHAR* argv[])
{
	int i;
	Dijkstra();

	puts("\nKomsuluk Matisi\n");
	for (i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
			printf("%5d", GRAF[i][j]);
		printf("\n\n\n");
	}

	/* maliyet sonucu ekran yazdiriliyor */
	puts("\nMaliyetler\n");
	for (i = 0; i < N; ++i)
		printf("EKM[%d]=%d\n", i, EKM[i]);

	/* rota ekrana yazdýrýlýyor */
	puts("\nRotalar\n");
	for (i = 0; i < N; ++i)
		printf("ROTA[%d]=%s\n", i, ROTA[i]);
	getchar();
}

void Dijkstra()
{
	char *ptr, ELEALINDI[N] = { 0 };
	int i, j, ead, ek;
	EKM[0] = 0;
	for (i = 1; i < N; ++i)
		EKM[i] = EBAS;
	ead = 0; /* baþlangýçta ele alýnan düðüm */

	for (i = 0; i < N; ++i)
	{
		for (j = 0; j < N; ++j)
		if (!ELEALINDI[j])
		if (GRAF[ead][j] != -1) /* baðlantýlý ise */
		if (EKM[j]>GRAF[ead][j] + EKM[ead])
		{
			EKM[j] = GRAF[ead][j] + EKM[ead];
			strcpy(ROTA[j], ROTA[ead]);
			ptr = ROTA[j];
			while (*ptr != NULL)
				++ptr;
			*ptr = 'A' + ead;
		}
		ek = EBAS;
		for (j = 1; j < N; ++j)
		if (!ELEALINDI[j])
		if (EKM[j] < ek)
		{
			ek = EKM[j];
			ead = j;
		}
		/* ele alýnan düðüm iþaretlendi */
		ELEALINDI[ead] = 1;
	}
}