using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000364 RID: 868
	public class ObjectLanguageBaseDescriber : LanguageBaseDescriber
	{
		// Token: 0x0600664F RID: 26191 RVA: 0x001F41F0 File Offset: 0x001F23F0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectLanguageBaseDescriber()
		{
			Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ObjectLanguageBaseDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr);
			ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, "objectVisual");
			ObjectLanguageBaseDescriber.NativeFieldInfoPtr_bgVisualParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, "bgVisualParent");
			ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectLanguageVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, "objectLanguageVisuals");
			ObjectLanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToObjectLanguageBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, "OnToggleToObjectLanguageBase");
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToObjectLanguageBase_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684720);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToObjectLanguageBase_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684721);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684722);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_ObjectLanguageBase_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684723);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684724);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForObjectLanguageBase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684725);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684726);
			ObjectLanguageBaseDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr, 100684727);
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x001F4310 File Offset: 0x001F2510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263462, RefRangeEnd = 263463, XrefRangeStart = 263458, XrefRangeEnd = 263462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnToggleToObjectLanguageBase(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_add_OnToggleToObjectLanguageBase_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x001F4354 File Offset: 0x001F2554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263463, XrefRangeEnd = 263467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnToggleToObjectLanguageBase(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_remove_OnToggleToObjectLanguageBase_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x001F4398 File Offset: 0x001F2598
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 263468, RefRangeEnd = 263480, XrefRangeStart = 263467, XrefRangeEnd = 263468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(ObjectLanguageBase detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x001F43DC File Offset: 0x001F25DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 263468, RefRangeEnd = 263480, XrefRangeStart = 263468, XrefRangeEnd = 263480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(ObjectLanguageBase detail, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_ObjectLanguageBase_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x001F4438 File Offset: 0x001F2638
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 263490, RefRangeEnd = 263500, XrefRangeStart = 263480, XrefRangeEnd = 263490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(ObjectLanguageBase detail, Sprite bgSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bgSprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x001F448C File Offset: 0x001F268C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 263501, RefRangeEnd = 263517, XrefRangeStart = 263500, XrefRangeEnd = 263501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleVisualForObjectLanguageBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr_ToggleVisualForObjectLanguageBase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x001F44C0 File Offset: 0x001F26C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263522, RefRangeEnd = 263524, XrefRangeStart = 263517, XrefRangeEnd = 263522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectLanguageBaseDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x001F44FC File Offset: 0x001F26FC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectLanguageBaseDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectLanguageBaseDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectLanguageBaseDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x0003746B File Offset: 0x0003566B
		public ObjectLanguageBaseDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x001F4538 File Offset: 0x001F2738
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x00037474 File Offset: 0x00035674
		public unsafe Image objectVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x001F4568 File Offset: 0x001F2768
		// (set) Token: 0x0600665C RID: 26204 RVA: 0x00037493 File Offset: 0x00035693
		public unsafe Image bgVisualParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_bgVisualParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_bgVisualParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x001F4598 File Offset: 0x001F2798
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x000374B2 File Offset: 0x000356B2
		public unsafe Il2CppReferenceArray<GameObject> objectLanguageVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectLanguageVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_objectLanguageVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x001F45C8 File Offset: 0x001F27C8
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x000374D1 File Offset: 0x000356D1
		public unsafe Action OnToggleToObjectLanguageBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToObjectLanguageBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectLanguageBaseDescriber.NativeFieldInfoPtr_OnToggleToObjectLanguageBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043DA RID: 17370
		private static readonly IntPtr NativeFieldInfoPtr_objectVisual;

		// Token: 0x040043DB RID: 17371
		private static readonly IntPtr NativeFieldInfoPtr_bgVisualParent;

		// Token: 0x040043DC RID: 17372
		private static readonly IntPtr NativeFieldInfoPtr_objectLanguageVisuals;

		// Token: 0x040043DD RID: 17373
		private static readonly IntPtr NativeFieldInfoPtr_OnToggleToObjectLanguageBase;

		// Token: 0x040043DE RID: 17374
		private static readonly IntPtr NativeMethodInfoPtr_add_OnToggleToObjectLanguageBase_Public_add_Void_Action_0;

		// Token: 0x040043DF RID: 17375
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnToggleToObjectLanguageBase_Public_rem_Void_Action_0;

		// Token: 0x040043E0 RID: 17376
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_0;

		// Token: 0x040043E1 RID: 17377
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_ObjectLanguageBase_CancellationToken_0;

		// Token: 0x040043E2 RID: 17378
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_ObjectLanguageBase_Sprite_0;

		// Token: 0x040043E3 RID: 17379
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisualForObjectLanguageBase_Public_Void_0;

		// Token: 0x040043E4 RID: 17380
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040043E5 RID: 17381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
