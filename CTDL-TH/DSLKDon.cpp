#include<bits/stdc++.h>
using namespace std;

struct Node{
	int data;
	Node *next;
};

typedef struct Node *node;

//Cap phat dong mot node moi voi kieu du lieu la so nguyen x;
node makeNode(int x){
	node tmp = new Node();
	tmp->data = x;
	tmp->next = NULL;
	return tmp;
}

//Kiem tra rong
bool empty(node a){
	return a == NULL;
}

//Dem danh sach co bao nhieu phan tu
int Size(node a){
	int count = 0;
	while(a != NULL){
		++ count;
		a = a->next; // Gan dia chi cua node tiep theo cho node hien tai
		//Cho node hien tai nhay sang node tiep theo
	}
	return count;
}

//Them 1 phan tu vao dau danh sach lien ket
void insertFirst(node &a, int x){
	node tmp = makeNode(x);
	if(a == NULL){
		a = tmp;
	}
	else{
		tmp->next = a;
		a = tmp;
	}
}

void insertLast(node &a, int x){
	node tmp = makeNode(x);
	if(a == NULL){
		a = tmp;
	}
	else{
		node p = a;
		while(p->next != NULL){
			p = p->next;
		}
		p->next = tmp;
	} 
		
}

main(){
	cout << sizeof(Node) << endl;
	node head = NULL;
}
