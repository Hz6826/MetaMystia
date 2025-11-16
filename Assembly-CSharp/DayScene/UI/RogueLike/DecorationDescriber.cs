using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FB RID: 251
	public class DecorationDescriber : MonoBehaviour
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x000FAF54 File Offset: 0x000F9154
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationDescriber()
		{
			Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DecorationDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr);
			DecorationDescriber.NativeFieldInfoPtr_m_ItemDescriberCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, "m_ItemDescriberCluster");
			DecorationDescriber.NativeMethodInfoPtr_Describe_Public_Void_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668288);
			DecorationDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Decoration_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668289);
			DecorationDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668290);
			DecorationDescriber.NativeMethodInfoPtr_DescribeDecorations_Public_Static_Void_UIElementCluster_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668291);
			DecorationDescriber.NativeMethodInfoPtr_DescribeNull_Public_Static_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668292);
			DecorationDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668293);
			DecorationDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668294);
			DecorationDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, 100668295);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000FB038 File Offset: 0x000F9238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72532, XrefRangeEnd = 72555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Decoration decoration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(decoration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_Describe_Public_Void_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000FB07C File Offset: 0x000F927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(Decoration data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Decoration_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000FB0D8 File Offset: 0x000F92D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72555, XrefRangeEnd = 72584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000FB10C File Offset: 0x000F930C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72607, RefRangeEnd = 72609, XrefRangeStart = 72584, XrefRangeEnd = 72607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DescribeDecorations(UIElementCluster uiElementCluster, Decoration decoration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_DescribeDecorations_Public_Static_Void_UIElementCluster_Decoration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000FB154 File Offset: 0x000F9354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72638, RefRangeEnd = 72639, XrefRangeStart = 72609, XrefRangeEnd = 72638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DescribeNull(UIElementCluster uiElementCluster)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_DescribeNull_Public_Static_Void_UIElementCluster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000FB18C File Offset: 0x000F938C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000FB1C0 File Offset: 0x000F93C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72639, XrefRangeEnd = 72640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000FB1FC File Offset: 0x000F93FC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00010C66 File Offset: 0x0000EE66
		public DecorationDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000FB238 File Offset: 0x000F9438
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00010C6F File Offset: 0x0000EE6F
		public unsafe UIElementCluster m_ItemDescriberCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationDescriber.NativeFieldInfoPtr_m_ItemDescriberCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationDescriber.NativeFieldInfoPtr_m_ItemDescriberCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemDescriberCluster;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Void_Decoration_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Final_New_Void_Decoration_CancellationToken_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_DescribeDecorations_Public_Static_Void_UIElementCluster_Decoration_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Static_Void_UIElementCluster_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006C1 RID: 1729
		[ObfuscatedName("DayScene.UI.RogueLike.DecorationDescriber+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x06009942 RID: 39234 RVA: 0x0028E374 File Offset: 0x0028C574
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr);
				DecorationDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_decoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr, "decoration");
				DecorationDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100668296);
				DecorationDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__DescribeDecorations_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr, 100668297);
			}

			// Token: 0x06009943 RID: 39235 RVA: 0x0028E3DC File Offset: 0x0028C5DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationDescriber.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009944 RID: 39236 RVA: 0x0028E418 File Offset: 0x0028C618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72529, XrefRangeEnd = 72532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeDecorations_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.__c__DisplayClass4_0.NativeMethodInfoPtr__DescribeDecorations_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009945 RID: 39237 RVA: 0x00052EB1 File Offset: 0x000510B1
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032E1 RID: 13025
			// (get) Token: 0x06009946 RID: 39238 RVA: 0x0028E45C File Offset: 0x0028C65C
			// (set) Token: 0x06009947 RID: 39239 RVA: 0x00052EBA File Offset: 0x000510BA
			public unsafe Decoration decoration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_decoration);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationDescriber.__c__DisplayClass4_0.NativeFieldInfoPtr_decoration), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006337 RID: 25399
			private static readonly IntPtr NativeFieldInfoPtr_decoration;

			// Token: 0x04006338 RID: 25400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006339 RID: 25401
			private static readonly IntPtr NativeMethodInfoPtr__DescribeDecorations_b__0_Internal_Void_Image_0;
		}

		// Token: 0x020006C2 RID: 1730
		[ObfuscatedName("DayScene.UI.RogueLike.DecorationDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009948 RID: 39240 RVA: 0x0028E48C File Offset: 0x0028C68C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecorationDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr);
				DecorationDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr, "<>9");
				DecorationDescriber.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr, "<>9__5_0");
				DecorationDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr, 100668299);
				DecorationDescriber.__c.NativeMethodInfoPtr__DescribeNull_b__5_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr, 100668300);
			}

			// Token: 0x06009949 RID: 39241 RVA: 0x0028E508 File Offset: 0x0028C708
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600994A RID: 39242 RVA: 0x0028E544 File Offset: 0x0028C744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DescribeNull_b__5_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationDescriber.__c.NativeMethodInfoPtr__DescribeNull_b__5_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600994B RID: 39243 RVA: 0x00052ED9 File Offset: 0x000510D9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032E2 RID: 13026
			// (get) Token: 0x0600994C RID: 39244 RVA: 0x0028E588 File Offset: 0x0028C788
			// (set) Token: 0x0600994D RID: 39245 RVA: 0x00052EE2 File Offset: 0x000510E2
			public unsafe static DecorationDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecorationDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecorationDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecorationDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032E3 RID: 13027
			// (get) Token: 0x0600994E RID: 39246 RVA: 0x0028E5B0 File Offset: 0x0028C7B0
			// (set) Token: 0x0600994F RID: 39247 RVA: 0x00052EF4 File Offset: 0x000510F4
			public unsafe static Action<Image> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecorationDescriber.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecorationDescriber.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400633A RID: 25402
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400633B RID: 25403
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400633C RID: 25404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400633D RID: 25405
			private static readonly IntPtr NativeMethodInfoPtr__DescribeNull_b__5_0_Internal_Void_Image_0;
		}
	}
}
