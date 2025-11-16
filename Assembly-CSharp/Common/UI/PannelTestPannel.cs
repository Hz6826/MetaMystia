using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000385 RID: 901
	public class PannelTestPannel : UIPanel
	{
		// Token: 0x06006B23 RID: 27427 RVA: 0x00203DE8 File Offset: 0x00201FE8
		// Note: this type is marked as 'beforefieldinit'.
		static PannelTestPannel()
		{
			Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "PannelTestPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr);
			PannelTestPannel.NativeFieldInfoPtr_allPannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, "allPannels");
			PannelTestPannel.NativeFieldInfoPtr_m_MultipleChoicePannelOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, "m_MultipleChoicePannelOpenContext");
			PannelTestPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, 100685427);
			PannelTestPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, 100685428);
			PannelTestPannel.NativeMethodInfoPtr_OnMultipleChoiceMenuExit_Private_Void_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, 100685429);
			PannelTestPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, 100685430);
			PannelTestPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, 100685431);
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x00203EA4 File Offset: 0x002020A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271748, XrefRangeEnd = 271817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PannelTestPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00203EE0 File Offset: 0x002020E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271817, XrefRangeEnd = 271829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PannelTestPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00203F1C File Offset: 0x0020211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271829, XrefRangeEnd = 271851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMultipleChoiceMenuExit(Il2CppReferenceArray<GameObject> allSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(allSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PannelTestPannel.NativeMethodInfoPtr_OnMultipleChoiceMenuExit_Private_Void_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00203F60 File Offset: 0x00202160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PannelTestPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x00203F9C File Offset: 0x0020219C
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PannelTestPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PannelTestPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x00039FF5 File Offset: 0x000381F5
		public PannelTestPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06006B2A RID: 27434 RVA: 0x00203FD8 File Offset: 0x002021D8
		// (set) Token: 0x06006B2B RID: 27435 RVA: 0x00039FFE File Offset: 0x000381FE
		public unsafe Il2CppReferenceArray<GameObject> allPannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PannelTestPannel.NativeFieldInfoPtr_allPannels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PannelTestPannel.NativeFieldInfoPtr_allPannels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06006B2C RID: 27436 RVA: 0x00204008 File Offset: 0x00202208
		// (set) Token: 0x06006B2D RID: 27437 RVA: 0x0003A01D File Offset: 0x0003821D
		public MultipleChoicePannel.MultipleChoicePannelOpenContext m_MultipleChoicePannelOpenContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PannelTestPannel.NativeFieldInfoPtr_m_MultipleChoicePannelOpenContext);
				return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PannelTestPannel.NativeFieldInfoPtr_m_MultipleChoicePannelOpenContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04004704 RID: 18180
		private static readonly IntPtr NativeFieldInfoPtr_allPannels;

		// Token: 0x04004705 RID: 18181
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleChoicePannelOpenContext;

		// Token: 0x04004706 RID: 18182
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004707 RID: 18183
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004708 RID: 18184
		private static readonly IntPtr NativeMethodInfoPtr_OnMultipleChoiceMenuExit_Private_Void_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04004709 RID: 18185
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400470A RID: 18186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EA4 RID: 3748
		[ObfuscatedName("Common.UI.PannelTestPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010924 RID: 67876 RVA: 0x003D702C File Offset: 0x003D522C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PannelTestPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr);
				PannelTestPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, "<>9");
				PannelTestPannel.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, "<>9__2_0");
				PannelTestPannel.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, "<>9__2_1");
				PannelTestPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, 100685433);
				PannelTestPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, 100685434);
				PannelTestPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr, 100685435);
			}

			// Token: 0x06010925 RID: 67877 RVA: 0x003D70D0 File Offset: 0x003D52D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PannelTestPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PannelTestPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010926 RID: 67878 RVA: 0x003D710C File Offset: 0x003D530C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271737, XrefRangeEnd = 271742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPanelInitialize_b__2_0(Il2CppSystem.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PannelTestPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010927 RID: 67879 RVA: 0x003D7154 File Offset: 0x003D5354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271742, XrefRangeEnd = 271748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__2_1(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PannelTestPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010928 RID: 67880 RVA: 0x00090A6D File Offset: 0x0008EC6D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005675 RID: 22133
			// (get) Token: 0x06010929 RID: 67881 RVA: 0x003D71A8 File Offset: 0x003D53A8
			// (set) Token: 0x0601092A RID: 67882 RVA: 0x00090A76 File Offset: 0x0008EC76
			public unsafe static PannelTestPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PannelTestPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PannelTestPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PannelTestPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005676 RID: 22134
			// (get) Token: 0x0601092B RID: 67883 RVA: 0x003D71D0 File Offset: 0x003D53D0
			// (set) Token: 0x0601092C RID: 67884 RVA: 0x00090A88 File Offset: 0x0008EC88
			public unsafe static Func<Il2CppSystem.Object, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PannelTestPannel.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PannelTestPannel.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005677 RID: 22135
			// (get) Token: 0x0601092D RID: 67885 RVA: 0x003D71F8 File Offset: 0x003D53F8
			// (set) Token: 0x0601092E RID: 67886 RVA: 0x00090A9A File Offset: 0x0008EC9A
			public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PannelTestPannel.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PannelTestPannel.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7B0 RID: 42928
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A7B1 RID: 42929
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400A7B2 RID: 42930
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400A7B3 RID: 42931
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7B4 RID: 42932
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Internal_String_Object_0;

			// Token: 0x0400A7B5 RID: 42933
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;
		}
	}
}
