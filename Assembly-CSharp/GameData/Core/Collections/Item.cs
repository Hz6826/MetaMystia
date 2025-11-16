using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections
{
	// Token: 0x02000240 RID: 576
	public class Item : NonTradableObjectBase
	{
		// Token: 0x060047DC RID: 18396 RVA: 0x0019763C File Offset: 0x0019583C
		// Note: this type is marked as 'beforefieldinit'.
		static Item()
		{
			Il2CppClassPointerStore<Item>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Item");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item>.NativeClassPtr);
			Item.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677668);
			Item.NativeMethodInfoPtr_get_IsClothes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677669);
			Item.NativeMethodInfoPtr_get_IsDecoration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677670);
			Item.NativeMethodInfoPtr_get_IsRecord_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677671);
			Item.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677672);
			Item.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100677673);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x001976E4 File Offset: 0x001958E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189502, RefRangeEnd = 189505, XrefRangeStart = 189502, XrefRangeEnd = 189505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Item(int id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x0019772C File Offset: 0x0019592C
		public unsafe bool IsClothes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 189615, RefRangeEnd = 189616, XrefRangeStart = 189614, XrefRangeEnd = 189615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsClothes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x00197768 File Offset: 0x00195968
		public unsafe bool IsDecoration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 189617, RefRangeEnd = 189618, XrefRangeStart = 189616, XrefRangeEnd = 189617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsDecoration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x001977A4 File Offset: 0x001959A4
		public unsafe bool IsRecord
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 189619, RefRangeEnd = 189620, XrefRangeStart = 189618, XrefRangeEnd = 189619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Item.NativeMethodInfoPtr_get_IsRecord_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x001977E0 File Offset: 0x001959E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189620, XrefRangeEnd = 189626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Item.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0019782C File Offset: 0x00195A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189626, XrefRangeEnd = 189627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Item.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x00024FE0 File Offset: 0x000231E0
		public Item(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClothes_Public_get_Boolean_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDecoration_Public_get_Boolean_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecord_Public_get_Boolean_0;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;
	}
}
