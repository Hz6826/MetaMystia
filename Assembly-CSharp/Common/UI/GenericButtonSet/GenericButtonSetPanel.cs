using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.UI.GenericButtonSet
{
	// Token: 0x020003A5 RID: 933
	public class GenericButtonSetPanel : UIPanelParamExternOpen<GenericButtonSetParam>
	{
		// Token: 0x060070F3 RID: 28915 RVA: 0x0021655C File Offset: 0x0021475C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericButtonSetPanel()
		{
			Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GenericButtonSet", "GenericButtonSetPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr);
			GenericButtonSetPanel.NativeFieldInfoPtr_m_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, "m_Selection");
			GenericButtonSetPanel.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, "m_Field");
			GenericButtonSetPanel.NativeFieldInfoPtr_m_Instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, "m_Instances");
			GenericButtonSetPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, 100686324);
			GenericButtonSetPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_GenericButtonSetParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, 100686325);
			GenericButtonSetPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, 100686326);
			GenericButtonSetPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, 100686327);
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x00216618 File Offset: 0x00214818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281850, XrefRangeEnd = 281854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericButtonSetPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x00216654 File Offset: 0x00214854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281854, XrefRangeEnd = 281892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(GenericButtonSetParam openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericButtonSetPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_GenericButtonSetParam_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x002166A8 File Offset: 0x002148A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281892, XrefRangeEnd = 281898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericButtonSetPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x002166E4 File Offset: 0x002148E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281898, XrefRangeEnd = 281909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericButtonSetPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x0003D608 File Offset: 0x0003B808
		public GenericButtonSetPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x060070F9 RID: 28921 RVA: 0x00216720 File Offset: 0x00214920
		// (set) Token: 0x060070FA RID: 28922 RVA: 0x0003D611 File Offset: 0x0003B811
		public unsafe UIElementCluster m_Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x060070FB RID: 28923 RVA: 0x00216750 File Offset: 0x00214950
		// (set) Token: 0x060070FC RID: 28924 RVA: 0x0003D630 File Offset: 0x0003B830
		public unsafe RectTransform m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x060070FD RID: 28925 RVA: 0x00216780 File Offset: 0x00214980
		// (set) Token: 0x060070FE RID: 28926 RVA: 0x0003D64F File Offset: 0x0003B84F
		public unsafe List<GameObject> m_Instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Instances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.NativeFieldInfoPtr_m_Instances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AC9 RID: 19145
		private static readonly IntPtr NativeFieldInfoPtr_m_Selection;

		// Token: 0x04004ACA RID: 19146
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04004ACB RID: 19147
		private static readonly IntPtr NativeFieldInfoPtr_m_Instances;

		// Token: 0x04004ACC RID: 19148
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004ACD RID: 19149
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_GenericButtonSetParam_0;

		// Token: 0x04004ACE RID: 19150
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004ACF RID: 19151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EFE RID: 3838
		[ObfuscatedName("Common.UI.GenericButtonSet.GenericButtonSetPanel+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x06010DD7 RID: 69079 RVA: 0x003E5BD8 File Offset: 0x003E3DD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr);
				GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr, "first");
				GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_onButtonSubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr, "onButtonSubmitHandler");
				GenericButtonSetPanel.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr, 100686328);
				GenericButtonSetPanel.__c__DisplayClass4_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr, 100686329);
			}

			// Token: 0x06010DD8 RID: 69080 RVA: 0x003E5C54 File Offset: 0x003E3E54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetPanel.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DD9 RID: 69081 RVA: 0x003E5C90 File Offset: 0x003E3E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281829, XrefRangeEnd = 281849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0(UIElementCluster ui, string selection, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(selection);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetPanel.__c__DisplayClass4_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DDA RID: 69082 RVA: 0x00092EFE File Offset: 0x000910FE
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057CF RID: 22479
			// (get) Token: 0x06010DDB RID: 69083 RVA: 0x003E5CF4 File Offset: 0x003E3EF4
			// (set) Token: 0x06010DDC RID: 69084 RVA: 0x00092F07 File Offset: 0x00091107
			public unsafe UIButtonSimple first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057D0 RID: 22480
			// (get) Token: 0x06010DDD RID: 69085 RVA: 0x003E5D24 File Offset: 0x003E3F24
			// (set) Token: 0x06010DDE RID: 69086 RVA: 0x00092F26 File Offset: 0x00091126
			public unsafe Action<int> onButtonSubmitHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_onButtonSubmitHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_0.NativeFieldInfoPtr_onButtonSubmitHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAA2 RID: 43682
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x0400AAA3 RID: 43683
			private static readonly IntPtr NativeFieldInfoPtr_onButtonSubmitHandler;

			// Token: 0x0400AAA4 RID: 43684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAA5 RID: 43685
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_UIElementCluster_String_Int32_0;
		}

		// Token: 0x02000EFF RID: 3839
		[ObfuscatedName("Common.UI.GenericButtonSet.GenericButtonSetPanel+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Il2CppSystem.Object
		{
			// Token: 0x06010DDF RID: 69087 RVA: 0x003E5D54 File Offset: 0x003E3F54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericButtonSetPanel>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr);
				GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr, "index");
				GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
				GenericButtonSetPanel.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr, 100686330);
				GenericButtonSetPanel.__c__DisplayClass4_1.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr, 100686331);
			}

			// Token: 0x06010DE0 RID: 69088 RVA: 0x003E5DD0 File Offset: 0x003E3FD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericButtonSetPanel.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetPanel.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DE1 RID: 69089 RVA: 0x003E5E0C File Offset: 0x003E400C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281849, XrefRangeEnd = 281850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetPanel.__c__DisplayClass4_1.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DE2 RID: 69090 RVA: 0x00092F45 File Offset: 0x00091145
			public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057D1 RID: 22481
			// (get) Token: 0x06010DE3 RID: 69091 RVA: 0x003E5E40 File Offset: 0x003E4040
			// (set) Token: 0x06010DE4 RID: 69092 RVA: 0x00092F4E File Offset: 0x0009114E
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170057D2 RID: 22482
			// (get) Token: 0x06010DE5 RID: 69093 RVA: 0x003E5E68 File Offset: 0x003E4068
			// (set) Token: 0x06010DE6 RID: 69094 RVA: 0x00092F69 File Offset: 0x00091169
			public unsafe GenericButtonSetPanel.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericButtonSetPanel.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetPanel.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAA6 RID: 43686
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400AAA7 RID: 43687
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;

			// Token: 0x0400AAA8 RID: 43688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAA9 RID: 43689
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_0;
		}
	}
}
