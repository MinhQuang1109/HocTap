#include <stdio.h>
#include <string.h>

const int max = 100;
typedef struct {
	char tenTB[20];
	char diaChi[20];
	char sdt[20];
}TB;

typedef struct{
	int soTB;
	TB ds[100];
}DSTB;

void nhapTB(TB *s){
	fflush(stdin);
	printf("\nNhap tên thue bao: "); gets(s->tenTB);
	printf("Nhap dia chi: "); gets(s->diaChi);
	printf("Nhap sdt: "); gets(s->sdt);
	printf("-----\n");
}

void inTB(TB s){
	printf("%s %s %s\n", s.tenTB, s.diaChi, s.sdt);
}

void nhapDSTB(DSTB *s){
	int i;
	for(i = 0; i < s->soTB; i++){
		nhapTB(&s->ds[i]);
	}
}

void inDSTB(DSTB s){
	int i;
	for(i = 0; i < s.soTB; i++){
		inTB(s.ds[i]);
	}
}

void themTB(DSTB *s, TB x, int k){
	printf("\n");
	printf("\nNhap TB muon them");
	nhapTB(&x);
	printf("\nNhap vi tri muon them: ");
	scanf("%d", &k);
	if(s->soTB < max && k < s->soTB){
		for(int i = s->soTB - 1; i >= k; i--)
			s->ds[i+1] = s->ds[i];
		s->ds[k] = x;
		s->soTB++;
	}
	inDSTB(*s);
}

void xoaTB(DSTB *s, int c){
	printf("\nNhap vi tri can xoa: ");
	scanf("%d", &c);
	if(s->soTB > 0 && c < s->soTB)
	{
		for(int i = c + 1; i <= s->soTB-1; i++)
			s->ds[i-1] = s->ds[i];
		s->soTB --;
	}
	inDSTB(*s);
}

/*void timTBten(DSTB *s, int soTB){
	char ten[20];
	int count = 0;
	printf("\nNhap ten TB can tim: ");
	scanf("%s", ten);
	for(int i = 0; i < s->soTB; i++){
		if(strcmp(s->ds[i].tenTB, ten) == 0)
			count ++;
	}	
	if(count == 0)
		printf("Khong co ten TB trong danh sach.");
	else
		printf("Co ten TB trong danh sach.");
}*/

int tim(DSTB s, char *ten){
	printf("\nNhap ten TB can tim: ");
	scanf("%s", ten);
	for(int i = 0; i < s.soTB; i++)
		if(strcmp(s.ds[i].tenTB, ten) == 0)
			return 1;
	return 0;	
}

void tim_xoa(DSTB *s, char ten[])
{
	int k;
	k = tim(*s, ten);
	if(k != 0)
		xoaTB(s, k);
}

main(){
	TB s[100], x, a;
	char ten[100];
	DSTB ds;
	int soTB, k, c;
	printf("Nhap soTB: ");
	scanf("%d", &ds.soTB);
	
	nhapDSTB(&ds);
	inDSTB(ds);
	//themTB(&ds, x, k);
	//xoaTB(&ds, c);
	//timTBten(&ds, soTB);
	printf("%d", tim(ds, ten));
	tim_xoa(&ds, ten);
	
}
