#include <stdio.h>
 
void NhapManga(int a[], int n)
{
	for(int i = 0; i < n; i++){
		printf("\na[%d]=",i);
		scanf("%d", &a[i]);
	}
}

void InMang(int a[], int n)
{
	printf("\nMang co cac phan tu:");
	for(int i = 0; i < n; i++){
		printf("%d ", a[i]);
	}
}

int SoLonNhat(int a[], int n){
	int max = a[0];
	for(int i = 0; i < n; i++){
		if(max < a[i])
			max = a[i];
	}
	printf("\nMax = %d", max);
	return max;
}

void MangSoChan(int a[], int b[], int n){
	int k = 0;
	for(int i = 0; i < n; i++){
		if(a[i] % 2 == 0){
			b[k] = a[i];
			k++;
		}	
	}
	printf("\nMang chua cac so chan la: ");
	for(int i = 0; i < k; i++){
		printf("%d ", b[k]);
	} 
}
int tinhTBC(int a[], int n){
	int kq = 0;
	for(int i = 0; i < n; i++){
		kq += a[i];
	}
	kq /= n;
	return kq;
}

bool timSoNguyen(int a[], int n, int x){
	printf("\nNhap x: "); scanf("%d", &x);
	for(int i = 0; i < n; i++){
		if(a[i] == x)
			return 1;
	} 
	return 0;
}

void sapXepTang(int a[100], int n){
	for(int i = 0; i < n; i++){
		for(int j = i+1; j < n; j++){
			if(a[i] > a[j])
			{
			int tmp = a[i];
			a[i] = a[j];
			a[j] = tmp;
			}
		}
	}
	printf("\nMang da sap xep tang la: ");
	for(int i =0; i < n; i++)
		printf("%d ", a[i]);
}
 
main(){
	int n, a[100], b[100],c[100], m, x; 
	printf("Nhap n:");
	scanf("%d", &n);
	NhapManga(a, n);
	InMang(a, n);
	SoLonNhat(a, n);
	MangSoChan(a, b, n);
	printf("\nTrung binh cong cac so trong mang la: %d ", tinhTBC(a, n));
	
	if(timSoNguyen(a, n, x) == true)
		printf("Co so nguyen trong mang");
	else
		printf("Khong co so nguyen trong mang");
	
	sapXepTang(a, n);
	
}
