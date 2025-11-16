using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core
{
	// Token: 0x02000235 RID: 565
	[Serializable]
	public class NonTradableObjectBase : Il2CppSystem.Object
	{
		// Token: 0x06004690 RID: 18064 RVA: 0x00192754 File Offset: 0x00190954
		// Note: this type is marked as 'beforefieldinit'.
		static NonTradableObjectBase()
		{
			Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core", "NonTradableObjectBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr);
			NonTradableObjectBase.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, "id");
			NonTradableObjectBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677284);
			NonTradableObjectBase.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677285);
			NonTradableObjectBase.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677286);
			NonTradableObjectBase.NativeMethodInfoPtr_get_BGSprite_Public_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677287);
			NonTradableObjectBase.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677288);
			NonTradableObjectBase.NativeMethodInfoPtr_GetText_Protected_Abstract_Virtual_New_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr, 100677289);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00192810 File Offset: 0x00190A10
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonTradableObjectBase(int id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonTradableObjectBase>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x00192858 File Offset: 0x00190A58
		public unsafe int Id
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBase.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x00192894 File Offset: 0x00190A94
		public unsafe virtual ObjectLanguageBase Text
		{
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 185900, RefRangeEnd = 186138, XrefRangeStart = 185900, XrefRangeEnd = 185900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonTradableObjectBase.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x001928D4 File Offset: 0x00190AD4
		public unsafe virtual Sprite BGSprite
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonTradableObjectBase.NativeMethodInfoPtr_get_BGSprite_Public_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00192920 File Offset: 0x00190B20
		[CallerCount(0)]
		public unsafe virtual Il2CppSystem.Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonTradableObjectBase.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x0019296C File Offset: 0x00190B6C
		[CallerCount(0)]
		public unsafe virtual ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NonTradableObjectBase.NativeMethodInfoPtr_GetText_Protected_Abstract_Virtual_New_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x00024ABF File Offset: 0x00022CBF
		public NonTradableObjectBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x001929C4 File Offset: 0x00190BC4
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x00024AC8 File Offset: 0x00022CC8
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBase.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NonTradableObjectBase.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ObjectLanguageBase_0;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr_get_BGSprite_Public_Virtual_New_get_Sprite_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Abstract_Virtual_New_ObjectLanguageBase_Int32_0;
	}
}
